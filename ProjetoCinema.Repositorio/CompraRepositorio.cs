using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class CompraRepositorio : CRUD<COMPRA>
    {
        public readonly CinemaContext contexto;

        public CompraRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(COMPRA entidade)
        {
            var COMPRA = contexto.COMPRA.First(x => x.ID_Compra == entidade.ID_Compra);
            contexto.Set<COMPRA>().Remove(COMPRA);
            contexto.SaveChanges();
        }

        public COMPRA ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.COMPRA.First(x => x.ID_Compra == idInt);
        }

        public IEnumerable<COMPRA> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.COMPRA.Where(x => x.ID_Compra == idInt).ToList();
        }

        public IEnumerable<COMPRA> ListarTodos()
        {
            return contexto.COMPRA.Include("CLIENTE");
        }

        public void Salvar(COMPRA entidade)
        {
            contexto.COMPRA.Add(entidade);
            contexto.SaveChanges();
        }
    }
}
