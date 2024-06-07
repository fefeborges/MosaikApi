using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<SecaoModel> Secao { get; set; }
        public DbSet<TamanhoModel> Tamanho { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SecaoMap());
            modelBuilder.ApplyConfiguration(new TamanhoMap());
            base.OnModelCreating(modelBuilder);

        }

    }
}
