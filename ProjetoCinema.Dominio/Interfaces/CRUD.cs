using System.Collections.Generic;

namespace ProjetoCinema.Dominio
{
    public interface CRUD<T> where T : class
    {
        void Salvar(T entidade);

        void Excluir(T entidade);

        IEnumerable<T> ListarTodos();

        T ListarPorId(string id);

        IEnumerable<T> ListarVariosPorId(string id);
    }
}
