using ProjetoCinema.Dominio;
using ProjetoCinima.Aplicacao;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Services;

namespace ProjetoCinema.UI.Web.Controllers
{
    public class ClassificacaoIndicativaController : Controller
    {
        private ClassificacaoIndicativaAplicacao appClass;

        public ClassificacaoIndicativaController()
        {
            appClass = AplicacaoConstrutor.ClassificacaoIndicativaAplicacaoEF();
        }

        // GET: ClassificacaoIndicativa
        public ActionResult Index()
        {
            var classIndicativa = appClass.Select();
            return View(classIndicativa);
        }

        //GET: ListClass
        public IEnumerable<CLASS_INDICATIVA> ListClass()
        {
            var classif = appClass.Select();
            return classif;
        }
    }
}