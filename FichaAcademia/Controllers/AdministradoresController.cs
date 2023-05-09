using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using FichaAcademia.Models;
using FichaAcademia.AcessoDados;
using FichaAcademia.AcessoDados.Interfaces;
using FichaAcademia.Dominio.Models;
using FichaAcademia.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FichaAcademia.Controllers
{
    public class AdministradoresController : Controller
    {
        private readonly IAdministradorRepositorio _administradorRepositorio;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public AdministradoresController(IAdministradorRepositorio administradorRepositorio, IHttpContextAccessor httpContextAccessor)
        {
            _administradorRepositorio = administradorRepositorio;
            _httpContextAccessor = httpContextAccessor;
        }

        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                HttpContext.SignOutAsync();
                HttpContext.Session.Clear();
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdministradorViewModel administradorViewModel)
        {
            if (!_administradorRepositorio.AdministradorExiste(administradorViewModel.Email, administradorViewModel.Senha))
            {
                ModelState.AddModelError(string.Empty, "Email e/ou senhas inválidos");
                return View(administradorViewModel);
            }

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, administradorViewModel.Email)
            };

            var userIdentity = new ClaimsIdentity(claims, "login");

            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync(principal);

            HttpContext.Session.SetString("Usuario", administradorViewModel.Email);

            ViewData["Usuario"] = HttpContext.Session.GetString("Usuario");

            return RedirectToAction("Home", "Administradores");
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }

        // GET: usuarios
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdministradorId,Nome,Email, Senha")] Administrador adm)
        {
            if (ModelState.IsValid)
            {
                await _administradorRepositorio.Inserir(adm);
                return RedirectToAction(nameof(Login));
            }
            return View(adm);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var adm = await _administradorRepositorio.PegarPeloId(id);
            if (adm == null)
            {
                return NotFound();
            }

            if (adm == null)
            {
                return NotFound();
            }
            return View(adm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdministradorId,Nome,Email, Senha")] Administrador adm)
        {
            if (id != adm.AdministradorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _administradorRepositorio.Atualizar(adm);
                return RedirectToAction(nameof(Login));
            }

            return View(adm);
        }


        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
            await _administradorRepositorio.Excluir(id);
            return Json("Usuário excluído com sucesso");
        }

        public JsonResult ObjetivoExiste(string email, string senha)
        {
            if (_administradorRepositorio.AdministradorExiste(email, senha))
                return Json("Usuário já existe");

            return Json(true);
        }

        public IActionResult Sobre()
        {
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }
    }
}

