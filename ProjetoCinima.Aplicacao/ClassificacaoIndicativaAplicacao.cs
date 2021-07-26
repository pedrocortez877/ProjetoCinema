using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class ClassificacaoIndicativaAplicacao
    {
        private readonly CRUD<CLASS_INDICATIVA> repositorio;

        public ClassificacaoIndicativaAplicacao(CRUD<CLASS_INDICATIVA> repo)
        {
            repositorio = repo;
        }

        public IEnumerable<CLASS_INDICATIVA> Select()
        {
            return repositorio.ListarTodos();
        }

        public CLASS_INDICATIVA ListaCLASS_INDICATIVA(string id)
        {
            return repositorio.ListarPorId(id);
        }

        public void Salvar(CLASS_INDICATIVA CLASS_INDICATIVA)
        {
            repositorio.Salvar(CLASS_INDICATIVA);
        }

        public void Delete(CLASS_INDICATIVA CLASS_INDICATIVA)
        {
            repositorio.Excluir(CLASS_INDICATIVA);
        }
    }
}
