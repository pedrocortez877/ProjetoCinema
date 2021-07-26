using ProjetoCinema.Dominio;
using System.Data.Entity;

namespace ProjetoCinema.Repositorio
{
    public partial class CinemaContext : DbContext
    {
        public CinemaContext()
            : base(@"data source=.\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=db_Cinema")
        {
        }

        public virtual DbSet<ASSENTO_SALA> ASSENTO_SALA { get; set; }
        public virtual DbSet<CLASS_INDICATIVA> CLASS_INDICATIVA { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<COMPRA> COMPRA { get; set; }
        public virtual DbSet<FILME> FILME { get; set; }
        public virtual DbSet<GENERO> GENERO { get; set; }
        public virtual DbSet<GENERO_FILME> GENERO_FILME { get; set; }
        public virtual DbSet<INGRESSO> INGRESSO { get; set; }
        public virtual DbSet<SALA> SALA { get; set; }
        public virtual DbSet<SESSAO> SESSAO { get; set; }
        public virtual DbSet<TIPO_INGRESSO> TIPO_INGRESSO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ASSENTO_SALA>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.ASSENTO_SALA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLASS_INDICATIVA>()
                .Property(e => e.Nome_Class)
                .IsUnicode(false);

            modelBuilder.Entity<CLASS_INDICATIVA>()
                .HasMany(e => e.FILME)
                .WithRequired(e => e.CLASS_INDICATIVA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.Nome_Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<CLIENTE>()
                .HasMany(e => e.COMPRA)
                .WithRequired(e => e.CLIENTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<COMPRA>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.COMPRA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FILME>()
                .Property(e => e.Titulo)
                .IsUnicode(false);

            modelBuilder.Entity<FILME>()
                .Property(e => e.Sinopse)
                .IsUnicode(false);

            modelBuilder.Entity<FILME>()
                .Property(e => e.Capa)
                .IsUnicode(false);

            modelBuilder.Entity<FILME>()
                .HasMany(e => e.GENERO_FILME)
                .WithRequired(e => e.FILME)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FILME>()
                .HasMany(e => e.SESSAO)
                .WithRequired(e => e.FILME)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GENERO>()
                .Property(e => e.Nome_Genero)
                .IsUnicode(false);

            modelBuilder.Entity<GENERO>()
                .HasMany(e => e.GENERO_FILME)
                .WithRequired(e => e.GENERO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<INGRESSO>()
                .Property(e => e.Valor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SALA>()
                .Property(e => e.Nome_Sala)
                .IsUnicode(false);

            modelBuilder.Entity<SALA>()
                .HasMany(e => e.ASSENTO_SALA)
                .WithRequired(e => e.SALA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SALA>()
                .HasMany(e => e.SESSAO)
                .WithRequired(e => e.SALA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SESSAO>()
                .Property(e => e.Horario)
                .IsUnicode(false);

            modelBuilder.Entity<SESSAO>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.SESSAO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TIPO_INGRESSO>()
                .Property(e => e.Nome_Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_INGRESSO>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<TIPO_INGRESSO>()
                .HasMany(e => e.INGRESSO)
                .WithRequired(e => e.TIPO_INGRESSO)
                .WillCascadeOnDelete(false);
        }
    }
}
