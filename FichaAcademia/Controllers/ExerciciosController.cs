using System;
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
using FichaAcademia.DAO;

namespace FichaAcademia.Controllers
{    
    [Authorize]
    public class ExerciciosController : Controller
    {
        private readonly IExercicioRepositorio _exercicioRepositorio;
        private readonly ICategoriaExercicioRepositorio _categoriaExercicioRepositorio;
        private readonly IListaExercicioRepositorio _listaExercicioRepositorio;

        private readonly Contexto _contexto;

        private const string ATTRIBUTE_NAME = "Nome";
        private const string ATTRIBUTE_CATEGORIA_ID = "CategoriaExercicioId";

        private SortedList<string, object> filterAttributes = new SortedList<string, object>();

        public ExerciciosController(Contexto contexto, IExercicioRepositorio exercicioRepositorio, ICategoriaExercicioRepositorio categoriaExercicioRepositorio, IListaExercicioRepositorio listaExercicioRepositorio)
        {
            _exercicioRepositorio = exercicioRepositorio;
            _categoriaExercicioRepositorio = categoriaExercicioRepositorio;
            _listaExercicioRepositorio = listaExercicioRepositorio;
            _contexto = contexto;
        }

        public async Task<IActionResult> Index(int? pagina)
        {
            const int itensPorPagina = 5;
            int numeroPagina = (pagina ?? 1);

            ViewBag.exerciciosCategoria = new List<SelectListItem>();
            ViewBag.exerciciosCategoria.Add(new SelectListItem("Selecione uma categoria de exercicio", "0"));

            foreach(var categoriaExercicio in _categoriaExercicioRepositorio.PegarTodos())
            {
                ViewBag.exerciciosCategoria.Add(new SelectListItem(categoriaExercicio.Nome, categoriaExercicio.CategoriaExercicioId.ToString()));
            }

            return View(await _contexto.Exercicios.ToList().ToPagedListAsync(numeroPagina, itensPorPagina));
        }

        public async Task<IActionResult> Listagem(int FichaId, int AlunoId)
        {
            ViewData["FichaId"] = FichaId;
            ViewData["AlunoId"] = AlunoId;

            return View(await _exercicioRepositorio.PegarTodos());
        }


        public async Task<IActionResult> AdicionarExercicio(int exercicioId, int frequencia, int repeticoes, int carga, int fichaId)
        {
            if (await _listaExercicioRepositorio.ExercicioExisteNaFicha(exercicioId, fichaId))
                return Json(false);

            ListaExercicio listaExercicio = new ListaExercicio
            {
                ExercicioId = exercicioId,
                Frequencia = frequencia,
                Repeticoes = repeticoes,
                Carga = carga,
                FichaId = fichaId
            };

            if (ModelState.IsValid)
            {
                await _listaExercicioRepositorio.Inserir(listaExercicio);
                return Json(true);
            }
            else return Json(false);
        }

               
        public async Task<IActionResult> Create()
        {
            ViewData["CategoriaExercicioId"] = new SelectList(await _categoriaExercicioRepositorio.PegarTodos().ToListAsync(), "CategoriaExercicioId", "Nome");
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ExercicioId,Nome,CategoriaExercicioId")] Exercicio exercicio)
        {
            if (ModelState.IsValid)
            {
                await _exercicioRepositorio.Inserir(exercicio);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaExercicioId"] = new SelectList(_categoriaExercicioRepositorio.PegarTodos(), "CategoriaExercicioId", "Nome", exercicio.CategoriaExercicioId);
            return View(exercicio);
        }

      
        public async Task<IActionResult> Edit(int id)
        {     
            var exercicio = await _exercicioRepositorio.PegarPeloId(id);
            if (exercicio == null)
            {
                return NotFound();
            }
            ViewData["CategoriaExercicioId"] = new SelectList(_categoriaExercicioRepositorio.PegarTodos(), "CategoriaExercicioId", "Nome", exercicio.CategoriaExercicioId);
            return View(exercicio);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ExercicioId,Nome,CategoriaExercicioId")] Exercicio exercicio)
        {
            if (id != exercicio.ExercicioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {   
                await _exercicioRepositorio.Atualizar(exercicio);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoriaExercicioId"] = new SelectList(_categoriaExercicioRepositorio.PegarTodos(), "CategoriaExercicioId", "Nome", exercicio.CategoriaExercicioId);
            return View(exercicio);
        }  
       
        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _exercicioRepositorio.Excluir(id);
            return Json("Exercício excluído com sucesso");
        }

        public async Task<JsonResult> ExercicioExiste(string nome, int ExercicioId)
        {
            if(ExercicioId == 0)
            {
                if (await _exercicioRepositorio.ExercicioExiste(nome))
                    return Json("Exercício já existe");

                return Json(true);
            }
            else
            {
                if(await _exercicioRepositorio.ExercicioExiste(nome, ExercicioId))
                    return Json("Exercício já existe");

                return Json(true);
            }
        }

        public JsonResult Filter(string nome, int categoriaExercicioId)
        {
            ExercicioDAO exercicioDAO = new ExercicioDAO();

            filterAttributes.Add(ATTRIBUTE_NAME, nome == null ? "" : nome);
            filterAttributes.Add(ATTRIBUTE_CATEGORIA_ID, categoriaExercicioId);

            return Json(exercicioDAO.Filter(filterAttributes));
        }
    }
}

