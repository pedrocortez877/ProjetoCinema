using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class SalaAplicacao
    {
        private readonly CRUD<SALA> repositorio;

        public SalaAplicacao(CRUD<SALA> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<SALA> Select()
        {
            return repositorio.ListarTodos();
        }

        public SALA ListaSALA(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(SALA SALA)
        {
            repositorio.Salvar(SALA);
        }

        public void Delete(SALA SALA)
        {
            repositorio.Excluir(SALA);
        }
    }
}
