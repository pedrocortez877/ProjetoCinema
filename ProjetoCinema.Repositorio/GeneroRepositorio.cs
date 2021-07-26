using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class GeneroRepositorio : CRUD<GENERO>
    {
        public readonly CinemaContext contexto;

        public GeneroRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(GENERO entidade)
        {
            var GENERO = contexto.GENERO.First(x => x.ID_Genero == entidade.ID_Genero);
            contexto.Set<GENERO>().Remove(GENERO);
            contexto.SaveChanges();
        }

        public GENERO ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.GENERO.First(x => x.ID_Genero == idInt);
        }

        public IEnumerable<GENERO> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.GENERO.Where(x => x.ID_Genero == idInt).ToList();
        }

        public IEnumerable<GENERO> ListarTodos()
        {
            return contexto.GENERO;
        }

        public void Salvar(GENERO entidade)
        {
            if (entidade.ID_Genero > 0)
            {
                var genero = contexto.GENERO.First(x => x.ID_Genero == entidade.ID_Genero);
                genero.Nome_Genero = entidade.Nome_Genero;
            }
            else
            {
                contexto.GENERO.Add(entidade);
            }
        }
    }
}
