using GerenciamentoMecanica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoMecanica.Infra.Persistence.Configurations
{
    public class AddressConfigurations : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("tb_address");

            builder
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(a => a.Number)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(a => a.Complement)
                .HasMaxLength(50);

            builder
                .Property(a => a.ZipCode)
                .IsRequired()
                .HasMaxLength(9);

            builder
                .Property(a => a.District)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(a => a.City)
                .IsRequired()
                .HasMaxLength(25);

            builder
                .Property(a => a.State)
                .IsRequired();
        }
    }
}
