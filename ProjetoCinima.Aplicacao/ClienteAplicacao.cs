using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class ClienteAplicacao
    {
        private readonly CRUD<CLIENTE> repositorio;

        public ClienteAplicacao(CRUD<CLIENTE> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<CLIENTE> Select()
        {
            return repositorio.ListarTodos();
        }

        public CLIENTE ListaCLIENTE(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(CLIENTE CLIENTE)
        {
            repositorio.Salvar(CLIENTE);
        }

        public void Delete(CLIENTE CLIENTE)
        {
            repositorio.Excluir(CLIENTE);
        }
    }
}
