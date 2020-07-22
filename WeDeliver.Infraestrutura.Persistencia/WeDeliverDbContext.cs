using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using WeDeliver.Dominio.Entidades;
using WeDeliver.Infraestrutura.Persistencia.Configuracoes;

namespace WeDeliver.Infraestrutura.Persistencia
{
    public class WeDeliverDbContext : DbContext
    {
        public WeDeliverDbContext() { }

        public WeDeliverDbContext(DbContextOptions<WeDeliverDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pacote> Pacotes { get; set; }
        public DbSet<Objeto> Objetos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=WeDeliver;Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var prop in modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetProperties())
                .Where(p => p.ClrType == typeof(string)))
            {
                if (prop.GetColumnType() == null)
                    prop.SetColumnType("varchar(255)");
            }

            modelBuilder.ApplyConfiguration(new ClienteConfiguracao());
            modelBuilder.ApplyConfiguration(new PacoteConfiguracao());
            modelBuilder.ApplyConfiguration(new ObjetoConfiguracao());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries()
                .Where(e => e.Entity.GetType().GetProperty("DataCriacao") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCriacao").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCriacao").IsModified = false;
                }
            }

            return base.SaveChanges();
        }

    }
}
