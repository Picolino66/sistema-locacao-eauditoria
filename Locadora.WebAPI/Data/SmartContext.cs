using Locadora.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Locadora.WebAPI.Data
{
    public class SmartContext : DbContext
    {
        public SmartContext(DbContextOptions<SmartContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Locacao>()
                .HasKey(CF => new {CF.ClienteId, CF.FilmeId});
        }

    }
}