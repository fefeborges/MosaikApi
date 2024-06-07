using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        public DbSet<ProdutoModel> Produto { get; set; }
        public DbSet<MarcaModel> Marca { get; set; }
        public DbSet<TipoProdutoModel> TipoProduto { get; set; }
        public DbSet<SecaoModel> Secao { get; set; }
        public DbSet<TamanhoModel> Tamanho { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MarcaMap());
            modelBuilder.ApplyConfiguration(new TipoProdutoMap());
            modelBuilder.ApplyConfiguration(new SecaoMap());
            modelBuilder.ApplyConfiguration(new TamanhoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);

        }

    }
}
