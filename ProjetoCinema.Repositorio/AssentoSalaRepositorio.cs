using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class AssentoSalaRepositorio : CRUD<ASSENTO_SALA>
    {
        public readonly CinemaContext contexto;

        public AssentoSalaRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(ASSENTO_SALA entidade)
        {
            var ASSENTO_SALA = contexto.ASSENTO_SALA.First(x => x.ID_Assento_Sala == entidade.ID_Assento_Sala);
            contexto.Set<ASSENTO_SALA>().Remove(ASSENTO_SALA);
            contexto.SaveChanges();
        }

        public ASSENTO_SALA ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.ASSENTO_SALA.First(x => x.ID_Assento_Sala == idInt);
        }

        public IEnumerable<ASSENTO_SALA> ListarTodos()
        {
            return contexto.ASSENTO_SALA;
        }

        public IEnumerable<ASSENTO_SALA> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.ASSENTO_SALA.Where(x => x.ID_Assento_Sala == idInt).ToList();
        }

        public IEnumerable<ASSENTO_SALA> ListarPorSala(int id)
        {
            return contexto.ASSENTO_SALA.Where(x => x.ID_Sala == id).ToList();
        }

        public void Salvar(ASSENTO_SALA entidade)
        {
            if (entidade.ID_Assento_Sala > 0)
            {
                var assento_sala = contexto.ASSENTO_SALA.First(x => x.ID_Assento_Sala == entidade.ID_Assento_Sala);
                assento_sala.ID_Sala = entidade.ID_Sala;
                assento_sala.Posicao_Assento = entidade.Posicao_Assento;
            }
            else
            {
                contexto.ASSENTO_SALA.Add(entidade);
            }
        }
    }
}
