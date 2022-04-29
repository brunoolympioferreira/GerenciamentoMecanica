using GerenciamentoMecanica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GerenciamentoMecanica.Infra
{
    public class GerenciamentoMecanicaDbContext : DbContext
    {
        public GerenciamentoMecanicaDbContext(DbContextOptions<GerenciamentoMecanicaDbContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
