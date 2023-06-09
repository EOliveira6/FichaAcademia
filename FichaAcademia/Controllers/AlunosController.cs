﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FichaAcademia.AcessoDados;
using FichaAcademia.Dominio.Models;
using FichaAcademia.AcessoDados.Interfaces;
using Microsoft.AspNetCore.Authorization;
using X.PagedList;

namespace FichaAcademia.Controllers
{
    [Authorize]
    public class AlunosController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        private readonly IObjetivoRepositorio _objetivoRepositorio;
        private readonly IProfessorRepositorio _professorRepositorio;
        private readonly Contexto _contexto;

        public AlunosController(Contexto contexto, IAlunoRepositorio alunoRepositorio, IObjetivoRepositorio objetivoRepositorio, IProfessorRepositorio professorRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
            _objetivoRepositorio = objetivoRepositorio;
            _professorRepositorio = professorRepositorio;
            _contexto = contexto;
        }

        public async Task<IActionResult> Index(int? pagina)
        {
            const int itensPorPagina = 5;
            int numeroPagina = (pagina ?? 1);
            var aluno1 = await _alunoRepositorio.PegarTodos();
            return View(await aluno1.ToPagedListAsync(numeroPagina, itensPorPagina));
        }



        [HttpPost]
        public async Task<IActionResult> Index(string txtProcurar, int? pagina)
        {
            const int itensPorPagina = 5;
            int numeroPagina = (pagina ?? 1);
            if (!String.IsNullOrEmpty(txtProcurar))
            {
                return View(await _contexto.Alunos.Where(x => x.NomeCompleto.ToUpper().Contains(txtProcurar.ToUpper())).ToPagedListAsync(numeroPagina, itensPorPagina));
            }

            var aluno1 = await _alunoRepositorio.PegarTodos();
            return View(await aluno1.ToPagedListAsync(numeroPagina, itensPorPagina));
        }

        public IActionResult Create()
        {
            ViewData["ObjetivoId"] = new SelectList(_objetivoRepositorio.PegarTodos(), "ObjetivoId", "Nome");
            ViewData["ProfessorId"] = new SelectList(_professorRepositorio.PegarTodos(), "ProfessorId", "Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlunoId,NomeCompleto,Idade,Peso,ObjetivoId,ProfessorId,FrequenciaSemanal")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                await _alunoRepositorio.Inserir(aluno);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ObjetivoId"] = new SelectList(_objetivoRepositorio.PegarTodos(), "ObjetivoId", "Nome", aluno.ObjetivoId);
            ViewData["ProfessorId"] = new SelectList(_professorRepositorio.PegarTodos(), "ProfessorId", "Nome", aluno.ProfessorId);
            return View(aluno);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var aluno = await _alunoRepositorio.PegarPeloId(id);
            if (aluno == null)
            {
                return NotFound();
            }
            ViewData["ObjetivoId"] = new SelectList(_objetivoRepositorio.PegarTodos(), "ObjetivoId", "Nome", aluno.ObjetivoId);
            ViewData["ProfessorId"] = new SelectList(_professorRepositorio.PegarTodos(), "ProfessorId", "Nome", aluno.ProfessorId);
            return View(aluno);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlunoId,NomeCompleto,Idade,Peso,ObjetivoId,ProfessorId,FrequenciaSemanal")] Aluno aluno)
        {
            if (id != aluno.AlunoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _alunoRepositorio.Atualizar(aluno);
                return RedirectToAction(nameof(Index));
            }
            ViewData["ObjetivoId"] = new SelectList(_objetivoRepositorio.PegarTodos(), "ObjetivoId", "Nome", aluno.ObjetivoId);
            ViewData["ProfessorId"] = new SelectList(_professorRepositorio.PegarTodos(), "ProfessorId", "Nome", aluno.ProfessorId);
            return View(aluno);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _alunoRepositorio.Excluir(id);
            return Json("Aluno excluído com sucesso");
        }

        public async Task<JsonResult> AlunoExiste(string NomeCompleto, int AlunoId)
        {
            if (AlunoId == 0)
            {
                if (await _alunoRepositorio.AlunoExiste(NomeCompleto))
                    return Json("Aluno já existe");

                return Json(true);
            }
            else
            {
                if (await _alunoRepositorio.AlunoExiste(NomeCompleto, AlunoId))
                    return Json("Aluno já existe");

                return Json(true);
            }
        }
    }
}

