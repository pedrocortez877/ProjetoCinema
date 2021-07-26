using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class IngressoRepositorio : CRUD<INGRESSO>
    {
        public readonly CinemaContext contexto;

        public IngressoRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(INGRESSO entidade)
        {
            var INGRESSO = contexto.INGRESSO.First(x => x.ID_Ingresso == entidade.ID_Ingresso);
            contexto.Set<INGRESSO>().Remove(INGRESSO);
            contexto.SaveChanges();
        }

        public INGRESSO ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.INGRESSO
                .Include("ASSENTO_SALA")
                .Include("SESSAO")
                .Include("TIPO_INGRESSO")
                .First(x => x.ID_Ingresso == idInt);
        }

        public IEnumerable<INGRESSO> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.INGRESSO
                .Include("ASSENTO_SALA")
                .Where(x => x.ID_Ingresso == idInt)
                .ToList();
        }

        public IEnumerable<INGRESSO> ListaAssentosOcupados(int id)
        {
            IEnumerable<INGRESSO> ingressos =
                contexto.INGRESSO
                    .Include("ASSENTO_SALA")
                    .Where(x => x.ID_Sessao == id)
                    .ToList();
            return ingressos;
        }

        public IEnumerable<INGRESSO> ListarTodos()
        {
            return contexto.INGRESSO;
        }

        public void Salvar(INGRESSO entidade)
        {
            contexto.INGRESSO.Add(entidade);
            contexto.SaveChanges();
        }

        public IEnumerable<INGRESSO> ListarPorCompra(string id_compra)
        {
            int.TryParse(id_compra, out int idInt);
            return contexto.INGRESSO
                .Include("ASSENTO_SALA")
                .Include("TIPO_INGRESSO")
                .Where(x => x.ID_Compra == idInt);
        }
    }
}
