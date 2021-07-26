using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class CompraAplicacao
    {
        private readonly CRUD<COMPRA> repositorio;

        public CompraAplicacao(CRUD<COMPRA> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<COMPRA> Select()
        {
            return repositorio.ListarTodos();
        }

        public COMPRA ListaCOMPRA(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(COMPRA COMPRA)
        {
            repositorio.Salvar(COMPRA);
        }

        public void Delete(COMPRA COMPRA)
        {
            repositorio.Excluir(COMPRA);
        }
    }
}
