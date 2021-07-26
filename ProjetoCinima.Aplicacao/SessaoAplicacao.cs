using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class SessaoAplicacao
    {
        private readonly CRUD<SESSAO> repositorio;

        public SessaoAplicacao(CRUD<SESSAO> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<SESSAO> Select()
        {
            return repositorio.ListarTodos();
        }

        public SESSAO ListaPorId(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public IEnumerable<SESSAO> ListarVariosPorId(string id)
        {
            return repositorio.ListarVariosPorId(id);
        }

        public void Salvar(SESSAO SESSAO)
        {
            repositorio.Salvar(SESSAO);
        }

        public void Delete(SESSAO SESSAO)
        {
            repositorio.Excluir(SESSAO);
        }
    }
}
