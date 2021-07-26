using ProjetoCinema.Dominio;
using ProjetoCinema.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class IngressoAplicacao
    {
        private readonly CRUD<INGRESSO> repositorio;

        public IngressoAplicacao(CRUD<INGRESSO> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<INGRESSO> Select()
        {
            return repositorio.ListarTodos();
        }

        public INGRESSO ListaINGRESSO(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(INGRESSO INGRESSO)
        {
            repositorio.Salvar(INGRESSO);
        }

        public void Delete(INGRESSO INGRESSO)
        {
            repositorio.Excluir(INGRESSO);
        }

        public IEnumerable<INGRESSO> ListarPorCompra(string id)
        {
            var ingressos = new IngressoRepositorio().ListarPorCompra(id);
            return ingressos;
        }

        public IEnumerable<INGRESSO> ListaAssentosOcupados(int id)
        {
            var ingressos = new IngressoRepositorio().ListaAssentosOcupados(id);
            return ingressos;
        }
    }
}
