using ProjetoCinima.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoCinema.UI.Web.Controllers
{
    public class CompraController : Controller
    {
        private CompraAplicacao appCompra;
        private IngressoAplicacao appIngresso;

        public CompraController()
        {
            appCompra = AplicacaoConstrutor.CompraAplicacaoEF();
            appIngresso = AplicacaoConstrutor.IngressoAplicacaoEF();
        }

        // GET: Compra
        public ActionResult Index()
        {
            var compras = appCompra.Select();
            return View(compras);
        }

        //GET: Detalhes
        public ActionResult Detalhes(int ID_Compra)
        {
            var ingressos = appIngresso.ListarPorCompra(ID_Compra.ToString());
            return View(ingressos);
        }
    }
}