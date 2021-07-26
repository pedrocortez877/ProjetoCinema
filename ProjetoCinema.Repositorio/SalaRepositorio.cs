using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class SalaRepositorio : CRUD<SALA>
    {
        public readonly CinemaContext contexto;

        public SalaRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(SALA entidade)
        {
            var SALA = contexto.SALA.First(x => x.ID_Sala == entidade.ID_Sala);
            contexto.Set<SALA>().Remove(SALA);
            contexto.SaveChanges();
        }

        public SALA ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.SALA.First(x => x.ID_Sala == idInt);
        }

        public IEnumerable<SALA> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.SALA.Where(x => x.ID_Sala == idInt).ToList();
        }

        public IEnumerable<SALA> ListarTodos()
        {
            return contexto.SALA;
        }

        public void Salvar(SALA entidade)
        {
            if (entidade.ID_Sala > 0)
            {
                var sala = contexto.SALA.First(x => x.ID_Sala == entidade.ID_Sala);
                sala.Capacidade = entidade.Capacidade;
                sala.Nome_Sala = entidade.Nome_Sala;
            }
            else
            {
                contexto.SALA.Add(entidade);
            }
        }
    }
}
