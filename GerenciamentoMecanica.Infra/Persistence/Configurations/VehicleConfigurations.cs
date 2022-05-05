using GerenciamentoMecanica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoMecanica.Infra.Persistence.Configurations
{
    public class VehicleConfigurations : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder
                .ToTable("tb_vehicle");

            builder.HasKey(v => v.Id);

            builder
                .Property(v => v.Manufacturer)
                .IsRequired();

            builder
                .Property(v => v.Brand)
                .IsRequired()
                .HasMaxLength(25);
            builder
                .Property(v => v.YearOfManufacture)
                .IsRequired();

            builder
                .Property(v => v.LicensePlate)
                .IsRequired()
                .HasMaxLength(7);

            builder
                .HasOne(c => c.Client)
                .WithMany(v => v.Vehicles)
                .HasForeignKey(v => v.ClientId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
