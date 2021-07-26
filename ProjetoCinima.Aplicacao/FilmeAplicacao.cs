using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class FilmeAplicacao
    {
        private readonly CRUD<FILME> repositorio;

        public FilmeAplicacao(CRUD<FILME> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<FILME> Select()
        {
            return repositorio.ListarTodos();
        }

        public FILME ListaFILME(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(FILME FILME)
        {
            repositorio.Salvar(FILME);
        }

        public void Delete(FILME FILME)
        {
            repositorio.Excluir(FILME);
        }
    }
}
