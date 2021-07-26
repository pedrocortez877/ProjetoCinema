using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class GeneroFilmeRepositorio : CRUD<GENERO_FILME>
    {
        public readonly CinemaContext contexto;

        public GeneroFilmeRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(GENERO_FILME entidade)
        {
            var GENERO_FILME = contexto.GENERO_FILME.First(x => x.ID_Gen_Filme == entidade.ID_Gen_Filme);
            contexto.Set<GENERO_FILME>().Remove(GENERO_FILME);
            contexto.SaveChanges();
        }

        public GENERO_FILME ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.GENERO_FILME.First(x => x.ID_Gen_Filme == idInt);
        }

        public IEnumerable<GENERO_FILME> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.GENERO_FILME.Where(x => x.ID_Gen_Filme == idInt).ToList();
        }

        public IEnumerable<GENERO_FILME> ListarTodos()
        {
            return contexto.GENERO_FILME;
        }

        public void Salvar(GENERO_FILME entidade)
        {
            if (entidade.ID_Gen_Filme > 0)
            {
                var genero_filme = contexto.GENERO_FILME.First(x => x.ID_Gen_Filme == entidade.ID_Gen_Filme);
                genero_filme.ID_Filme = entidade.ID_Filme;
                genero_filme.ID_Genero = entidade.ID_Genero;
            }
            else
            {
                contexto.GENERO_FILME.Add(entidade);
            }
        }
    }
}
