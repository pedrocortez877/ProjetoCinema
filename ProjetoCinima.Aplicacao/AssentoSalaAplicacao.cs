using ProjetoCinema.Dominio;
using ProjetoCinema.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class AssentoSalaAplicacao
    {
        private readonly CRUD<ASSENTO_SALA> repositorio;

        public AssentoSalaAplicacao(CRUD<ASSENTO_SALA> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<ASSENTO_SALA> Select()
        {
            return repositorio.ListarTodos();
        }

        public ASSENTO_SALA ListaASSENTO_SALA(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(ASSENTO_SALA ASSENTO_SALA)
        {
            repositorio.Salvar(ASSENTO_SALA);
        }

        public void Delete(ASSENTO_SALA ASSENTO_SALA)
        {
            repositorio.Excluir(ASSENTO_SALA);
        }
    }
}
