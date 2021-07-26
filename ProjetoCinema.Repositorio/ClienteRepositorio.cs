using ProjetoCinema.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinema.Repositorio
{
    public class ClienteRepositorio : CRUD<CLIENTE>
    {
        public readonly CinemaContext contexto;

        public ClienteRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(CLIENTE entidade)
        {
            var CLIENTE = contexto.CLIENTE.First(x => x.ID_Cliente == entidade.ID_Cliente);
            contexto.Set<CLIENTE>().Remove(CLIENTE);
            contexto.SaveChanges();
        }

        public CLIENTE ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.CLIENTE.First(x => x.ID_Cliente == idInt);
        }

        public IEnumerable<CLIENTE> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.CLIENTE.Where(x => x.ID_Cliente == idInt).ToList();
        }

        public IEnumerable<CLIENTE> ListarTodos()
        {
            return contexto.CLIENTE;
        }

        public void Salvar(CLIENTE entidade)
        {
            if (entidade.ID_Cliente > 0)
            {
                var cliente = contexto.CLIENTE.First(x => x.ID_Cliente == entidade.ID_Cliente);
                cliente.CPF = entidade.CPF;
                cliente.Email = entidade.Email;
                cliente.Nome_Cliente = entidade.Nome_Cliente;
                cliente.Senha = entidade.Senha;
                cliente.Dt_Nasc = entidade.Dt_Nasc;
            }
            else
            {
                contexto.CLIENTE.Add(entidade);
            }
        }
    }
}
