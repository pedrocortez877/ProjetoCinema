using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class TipoIngressoAplicacao
    {
        private readonly CRUD<TIPO_INGRESSO> repositorio;

        public TipoIngressoAplicacao(CRUD<TIPO_INGRESSO> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<TIPO_INGRESSO> Select()
        {
            return repositorio.ListarTodos();
        }

        public TIPO_INGRESSO ListaTIPO_INGRESSO(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(TIPO_INGRESSO TIPO_INGRESSO)
        {
            repositorio.Salvar(TIPO_INGRESSO);
        }

        public void Delete(TIPO_INGRESSO TIPO_INGRESSO)
        {
            repositorio.Excluir(TIPO_INGRESSO);
        }
    }
}
