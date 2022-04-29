using GerenciamentoMecanica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoMecanica.Infra.Persistence.Configurations
{
    public class ServiceConfigurations : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
                .ToTable("tb_service");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(s => s.ServiceDescription)
                .IsRequired()
                .HasMaxLength(200);

            builder
                .Property(s => s.ServiceStatus)
                .IsRequired();

            builder
                .HasOne(c => c.Client)
                .WithMany(c => c.Services)
                .HasForeignKey(s => s.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.Vehicle)
                .WithMany(c => c.Services)
                .HasForeignKey(s => s.IdVehicle)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
