using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class GeneroAplicacao
    {
        private readonly CRUD<GENERO> repositorio;

        public GeneroAplicacao(CRUD<GENERO> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<GENERO> Select()
        {
            return repositorio.ListarTodos();
        }

        public GENERO ListaGENERO(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(GENERO GENERO)
        {
            repositorio.Salvar(GENERO);
        }

        public void Delete(GENERO GENERO)
        {
            repositorio.Excluir(GENERO);
        }
    }
}
