using ProjetoCinema.Dominio;
using ProjetoCinima.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoCinema.UI.Web.Controllers
{
    public class SessaoController : Controller
    {
        private SessaoAplicacao appSessao;

        public SessaoController()
        {
            appSessao = AplicacaoConstrutor.SessaoAplicacaoEF();
        }

        // GET: Sessao
        public ActionResult Index()
        {
            var sessoes = appSessao.Select();
            return View(sessoes);
        }


        public ActionResult SessoesDisponiveis(int ID_Filme)
        {
            var sessaoFilme = appSessao.ListarVariosPorId(ID_Filme.ToString());
            Console.WriteLine(sessaoFilme);
            return View(sessaoFilme);
        }

    }
}