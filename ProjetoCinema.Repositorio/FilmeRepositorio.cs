using System;
using System.Collections.Generic;
using System.Linq;
using ProjetoCinema.Dominio;

namespace ProjetoCinema.Repositorio
{
    public class FilmeRepositorio : CRUD<FILME>
    {
        public readonly CinemaContext contexto;

        public FilmeRepositorio()
        {
            contexto = new CinemaContext();
        }

        public void Excluir(FILME entidade)
        {
            var filme = contexto.FILME.First(x => x.ID_Filme == entidade.ID_Filme);
            contexto.Set<FILME>().Remove(filme);
            contexto.SaveChanges();
        }

        public FILME ListarPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.FILME.First(x => x.ID_Filme == idInt);
        }

        public IEnumerable<FILME> ListarVariosPorId(string id)
        {
            int.TryParse(id, out int idInt);
            return contexto.FILME.Where(x => x.ID_Filme == idInt).ToList();
        }

        public IEnumerable<FILME> ListarTodos()
        {
            return contexto.FILME.Include("CLASS_INDICATIVA").ToList();
        }

        public void Salvar(FILME entidade)
        {
            if (entidade.ID_Filme > 0)
            {
                var filme = contexto.FILME.First(x => x.ID_Filme == entidade.ID_Filme);
                filme.Titulo = entidade.Titulo;
                filme.Sinopse = entidade.Sinopse;
                filme.ID_Class = entidade.ID_Class;
            }
            else
            {
                try
                {
                    contexto.FILME.Add(entidade);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            contexto.SaveChanges();
        }
    }
}
