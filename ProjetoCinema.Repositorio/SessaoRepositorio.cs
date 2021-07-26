using ProjetoCinema.Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Entity;

namespace ProjetoCinema.Repositorio
{
    public class SessaoRepositorio : CRUD<SESSAO>
    {
        public readonly CinemaContext contexto;

        public SessaoRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(SESSAO entidade)
        {
            var SESSAO = contexto.SESSAO.First(x => x.ID_Sessao == entidade.ID_Sessao);
            contexto.Set<SESSAO>().Remove(SESSAO);
            contexto.SaveChanges();
        }

        public IEnumerable<SESSAO> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            var sessoes = contexto.SESSAO
                .Include(i => i.SALA.ASSENTO_SALA)
                .Include("FILME")
                .Where(x => x.ID_Filme == idInt);
            return sessoes;
        }

        public IEnumerable<SESSAO> ListarTodos()
        {
            return contexto.SESSAO.Include("SALA").ToList();
        }

        public void Salvar(SESSAO entidade)
        {
            contexto.SESSAO.Add(entidade);
        }

        public SESSAO ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.SESSAO
                .Include(i => i.SALA.ASSENTO_SALA)
                .Include("FILME")
                .First(x => x.ID_Sessao == idInt);
        }
    }
}
