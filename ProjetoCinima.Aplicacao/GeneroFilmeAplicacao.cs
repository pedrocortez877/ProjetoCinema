using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class GeneroFilmeAplicacao
    {
        private readonly CRUD<GENERO_FILME> repositorio;

        public GeneroFilmeAplicacao(CRUD<GENERO_FILME> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<GENERO_FILME> Select()
        {
            return repositorio.ListarTodos();
        }

        public GENERO_FILME ListaGENERO_FILME(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(GENERO_FILME GENERO_FILME)
        {
            repositorio.Salvar(GENERO_FILME);
        }

        public void Delete(GENERO_FILME GENERO_FILME)
        {
            repositorio.Excluir(GENERO_FILME);
        }
    }
}
