using ProjetoCinema.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCinima.Aplicacao
{
    public class AplicacaoConstrutor
    {
        public static FilmeAplicacao FilmeAplicacaoEF()
        {
            return new FilmeAplicacao(new FilmeRepositorio());
        }

        public static ClienteAplicacao ClienteAplicacaoEF()
        {
            return new ClienteAplicacao(new ClienteRepositorio());
        }

        public static CompraAplicacao CompraAplicacaoEF()
        {
            return new CompraAplicacao(new CompraRepositorio());
        }

        public static IngressoAplicacao IngressoAplicacaoEF()
        {
            return new IngressoAplicacao(new IngressoRepositorio());
        }

        public static SessaoAplicacao SessaoAplicacaoEF()
        {
            return new SessaoAplicacao(new SessaoRepositorio());
        }

        public static TipoIngressoAplicacao TipoIngressoAplicacaoEF()
        {
            return new TipoIngressoAplicacao(new TipoIngressoRepositorio());
        }

        public static SalaAplicacao SalaAplicacaoEF()
        {
            return new SalaAplicacao(new SalaRepositorio());
        }

        public static GeneroAplicacao GeneroAplicacaoEF()
        {
            return new GeneroAplicacao(new GeneroRepositorio());
        }

        public static GeneroFilmeAplicacao GeneroFilmeAplicacaoEF()
        {
            return new GeneroFilmeAplicacao(new GeneroFilmeRepositorio());
        }

        public static ClassificacaoIndicativaAplicacao ClassificacaoIndicativaAplicacaoEF()
        {
            return new ClassificacaoIndicativaAplicacao(new ClassificacaoIndicativaRepositorio());
        }

        public static AssentoSalaAplicacao AssentoSalaAplicacaoEF()
        {
            return new AssentoSalaAplicacao(new AssentoSalaRepositorio());
        }
    }
}
