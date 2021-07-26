using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class TipoIngressoRepositorio : CRUD<TIPO_INGRESSO>
    {
        public readonly CinemaContext contexto;

        public TipoIngressoRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(TIPO_INGRESSO entidade)
        {
            var TIPO_INGRESSO = contexto.TIPO_INGRESSO.First(x => x.ID_Tipo == entidade.ID_Tipo);
            contexto.Set<TIPO_INGRESSO>().Remove(TIPO_INGRESSO);
            contexto.SaveChanges();
        }

        public TIPO_INGRESSO ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.TIPO_INGRESSO.First(x => x.ID_Tipo == idInt);
        }

        public IEnumerable<TIPO_INGRESSO> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.TIPO_INGRESSO.Where(x => x.ID_Tipo == idInt).ToList();
        }

        public IEnumerable<TIPO_INGRESSO> ListarTodos()
        {
            return contexto.TIPO_INGRESSO;
        }

        public void Salvar(TIPO_INGRESSO entidade)
        {
            contexto.TIPO_INGRESSO.Add(entidade);
        }
    }
}
