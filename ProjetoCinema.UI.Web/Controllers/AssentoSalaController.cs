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
    public class AssentoSalaController : Controller
    {

        // GET: AssentoSala
        public ActionResult Index()
        {
            return View();
        }

        //Método para devolver assentos por sala
        public List<ASSENTO_SALA> ListaAssentosPorSala(string id_sala)
        {
            int.TryParse(id_sala, out int idInt);
            List<ASSENTO_SALA> assentos_sala = new AssentoSalaRepositorio().ListarPorSala(idInt).ToList();
            return assentos_sala;
        }
    }
}