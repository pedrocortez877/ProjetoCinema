using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class ClassificacaoIndicativaRepositorio : CRUD<CLASS_INDICATIVA>
    {
        public readonly CinemaContext contexto;

        public ClassificacaoIndicativaRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(CLASS_INDICATIVA entidade)
        {
            var CLASS_INDICATIVA = contexto.CLASS_INDICATIVA.First(x => x.ID_Class == entidade.ID_Class);
            contexto.Set<CLASS_INDICATIVA>().Remove(CLASS_INDICATIVA);
            contexto.SaveChanges();
        }

        public CLASS_INDICATIVA ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.CLASS_INDICATIVA.First(x => x.ID_Class == idInt);
        }

        public IEnumerable<CLASS_INDICATIVA> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.CLASS_INDICATIVA.Where(x => x.ID_Class == idInt).ToList();
        }

        public IEnumerable<CLASS_INDICATIVA> ListarTodos()
        {
            return contexto.CLASS_INDICATIVA;
        }

        public void Salvar(CLASS_INDICATIVA entidade)
        {
            if (entidade.ID_Class > 0)
            {
                var class_indicativa = contexto.CLASS_INDICATIVA.First(x => x.ID_Class == entidade.ID_Class);
                class_indicativa.Nome_Class = entidade.Nome_Class;
            }
            else
            {
                contexto.CLASS_INDICATIVA.Add(entidade);
            }
        }
    }
}
