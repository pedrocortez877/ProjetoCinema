using Newtonsoft.Json;
using ProjetoCinema.Dominio;
using ProjetoCinima.Aplicacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ProjetoCinema.UI.Web.Controllers
{
    public class IngressoController : Controller
    {
        private SessaoAplicacao appSessao;
        private CompraAplicacao appCompra;
        private IngressoAplicacao appIngresso;

        private const Double VI = 20.00;
        private const Double VM = 10.00;
        public IngressoController()
        {
            appSessao = AplicacaoConstrutor.SessaoAplicacaoEF();
            appCompra = AplicacaoConstrutor.CompraAplicacaoEF();
            appIngresso = AplicacaoConstrutor.IngressoAplicacaoEF();
        }

        // GET: Ingresso
        public ActionResult Index()
        {
            return View();
        }

        //GET: CompraIngresso
        public ActionResult CompraIngresso(int ID_Sessao)
        {
            var sessao = appSessao.ListaPorId(ID_Sessao.ToString());
            INGRESSO ingresso = new INGRESSO();
            ingresso.ID_Sessao = ID_Sessao;
            ingresso.SESSAO = sessao;

            return View(ingresso);
        }

        //POST: CompraIngresso
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CompraIngresso(INGRESSO ingresso)
        {
            if (ModelState.IsValid)
            {
                COMPRA compra = new COMPRA();
                compra.ID_Cliente = 1;
                compra.Dt_Compra = DateTime.Now;

                var finalId = appCompra.Select().Last().ID_Compra + 1;
                ingresso.ID_Compra = finalId;

                if (ingresso.ID_Tipo == 1)
                {
                    ingresso.Valor = (decimal)VI;
                }
                else
                {
                    ingresso.Valor = (decimal)VM;
                }

                appCompra.Salvar(compra);
                appIngresso.Salvar(ingresso);

                INGRESSO ingressoComp = appIngresso.ListaINGRESSO(ingresso.ID_Ingresso.ToString());
                return View("ExibeCompra", ingressoComp);
            }
            return View(ingresso);
        }

        public string ListaAssentosOcupados(int ID_SESSAO)
        {
            List<INGRESSO> ingressos = appIngresso.ListaAssentosOcupados(ID_SESSAO).ToList();
            List<int> assentos_ocupados = new List<int>();
            foreach(var ingresso in ingressos)
            {
                assentos_ocupados.Add(ingresso.ASSENTO_SALA.Posicao_Assento);
            }
            return JsonConvert.SerializeObject(assentos_ocupados);
        }

        public ActionResult ExibeCompra(INGRESSO ingresso)
        {
            return View(ingresso);
        }
    }
}