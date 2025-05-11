using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using retotecnico_bcp.Model;

namespace retotecnico_bcp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options){ }
        public DbSet<Moneda> Monedas { get; set; }
        public DbSet<TipoCambio> TipoCambios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoCambio>()
                .HasOne(e =>e.monedaOrigen)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TipoCambio>()
                .HasOne(e => e.monedaDestino)
                .WithMany()
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<TipoCambio>()
                .Property(t => t.dcTipoCambio)
                .HasColumnType("decimal(18, 10)");
        }

    }
}
