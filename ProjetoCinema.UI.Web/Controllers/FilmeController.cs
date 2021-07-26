using ProjetoCinema.Dominio;
using ProjetoCinema.Repositorio;
using ProjetoCinima.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoCinema.UI.Web.Controllers
{
    public class FilmeController : Controller
    {
        private FilmeAplicacao appFilme;
        private SessaoAplicacao appSessao;

        public FilmeController()
        {
            appFilme = AplicacaoConstrutor.FilmeAplicacaoEF();
            appSessao = AplicacaoConstrutor.SessaoAplicacaoEF();
        }

        // GET: Filme
        public ActionResult Index()
        {
            var filmes = appFilme.Select();
            return View(filmes);
        }

        //GET: Create - Filme
        public ActionResult Create()
        {
            return View();
        }

        //POST: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FILME filme)
        {
            if (ModelState.IsValid)
            {
                appFilme.Salvar(filme);
                return RedirectToAction("Index");
            }
            return View(filme);
        }
    }
}