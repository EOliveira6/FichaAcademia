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
    public class CategoriasExerciciosController : Controller
    {
        private readonly ICategoriaExercicioRepositorio _categoriaExercicioRepositorio;

        private readonly Contexto _contexto;

        private const string ATTRIBUTE_NAME = "Nome";

        private SortedList<string, object> filterAttributes = new SortedList<string, object>();


        public CategoriasExerciciosController(Contexto contexto, ICategoriaExercicioRepositorio categoriaExercicioRepositorio)
        {
            _categoriaExercicioRepositorio = categoriaExercicioRepositorio;
            _contexto = contexto;
        }

        public async Task<IActionResult> Index(int? pagina)
        {
            const int itensPorPagina = 5;
            int numeroPagina = (pagina ?? 1);
            return View(await _contexto.CategoriasExercicios.ToList().ToPagedListAsync(numeroPagina, itensPorPagina));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoriaExercicioId,Nome")] CategoriaExercicio categoriaExercicio)
        {
            if (ModelState.IsValid)
            {
                await _categoriaExercicioRepositorio.Inserir(categoriaExercicio);
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaExercicio);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var categoriaExercicio = await _categoriaExercicioRepositorio.PegarPeloId(id);
            if (categoriaExercicio == null)
            {
                return NotFound();
            }
            return View(categoriaExercicio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CategoriaExercicioId,Nome")] CategoriaExercicio categoriaExercicio)
        {
            if (id != categoriaExercicio.CategoriaExercicioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _categoriaExercicioRepositorio.Atualizar(categoriaExercicio);
                return RedirectToAction(nameof(Index));
            }
            return View(categoriaExercicio);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _categoriaExercicioRepositorio.Excluir(id);
            return Json("Categoria excluída com sucesso");
        }

        public async Task<JsonResult> CategoriaExiste(string nome, int CategoriaExercicioId)
        {
            if (CategoriaExercicioId == 0)
            {
                if (await _categoriaExercicioRepositorio.CategoriaExiste(nome))
                    return Json("Categoria já existe");

                return Json(true);
            }

            else
            {
                if (await _categoriaExercicioRepositorio.CategoriaExiste(nome, CategoriaExercicioId))
                    return Json("Categoria já existe");

                return Json(true);
            }
        }

        public JsonResult getAllCategoriasExercicios()
        {
            return Json(_contexto.CategoriasExercicios.ToList());
        }

        public JsonResult Filter(string nome)
        {
            CategoriaExercicioDAO dao = new CategoriaExercicioDAO();

            filterAttributes.Add(ATTRIBUTE_NAME, nome == null ? "" : nome);

            return Json(dao.Filter(filterAttributes));
        }

        /*     public override IActionResult Index()
             {

                 var lista = (DAO as CategoriasDAO).ListagemAlunosComFiltro(1, 9999999, "");
                 return View(lista);
             }

             public JsonResult CarregaCidades(int UFId)
             {
                 return Json(PreparaListaCidadesParaCombo(UFId));
             }

             private List<SelectListItem> PreparaListaCidadesParaCombo(int? ufId)
             {
                 if (ufId == null)
                     ufId = 0;
                 CidadeDAO cidadeDao = new CidadeDAO();
                 var cidades = cidadeDao.ListagemComFiltro("uf_id = " + ufId, "nome");

                 List<SelectListItem> listaCidades = new List<SelectListItem>();
                 listaCidades.Add(new SelectListItem("Selecione uma cidade...", "0"));
                 foreach (var cidade in cidades)
                 {
                     SelectListItem item = new SelectListItem(cidade.Nome, cidade.Id.ToString());
                     listaCidades.Add(item);
                 }
                 ViewBag.Cidades = listaCidades;
                 return listaCidades;
             }


             private void PreparaListaEstadosParaCombo()
             {
                 EstadoDAO dao = new EstadoDAO();
                 var estados = dao.ListagemComFiltro("", "UF");
                 //estados.Sort((A, B) => A.UF.CompareTo(B.UF));

                 List<SelectListItem> listaEstados = new List<SelectListItem>();
                 listaEstados.Add(new SelectListItem("Selecione um estado...", "0"));
                 foreach (var e in estados)
                 {
                     SelectListItem item = new SelectListItem(e.UF, e.Id.ToString());
                     listaEstados.Add(item);
                 }
                 ViewBag.Estados = listaEstados;
             }

             public IActionResult AtualizaGridIndex(int UfId, string nomeAluno)
             {
                 List<Aluno> lista;
                 if (UfId == 0)
                     lista = (DAO as AlunoDAO).ListagemAlunosComFiltro(1, int.MaxValue, nomeAluno);
                 else
                     lista = _categoriaExercicioRepositorio.ListagemAlunosComFiltro(UfId, UfId, nomeAluno);

                 return PartialView("pvGrid", lista);
             }



             public void SalvaEdicaoNome(int id, string nomeAluno)
             {
                 try
                 {
                     var categ =  _categoriaExercicioRepositorio.PegarPeloId(id).Result;
                     categ.Nome = nomeAluno;
                     _categoriaExercicioRepositorio.Atualizar(categ);               
                 }
                 catch
                 {
                     // gerar um log, depois vocês  fazem em casa :)
                 }
             }
         }
         */

    }
}
