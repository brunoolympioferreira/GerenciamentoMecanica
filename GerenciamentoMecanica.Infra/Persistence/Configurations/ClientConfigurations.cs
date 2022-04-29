using GerenciamentoMecanica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoMecanica.Infra.Persistence.Configurations
{
    public class ClientConfigurations : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .ToTable("tb_client");

            builder
                .HasKey(c => c.Id);

            builder
                .Property(c => c.FullName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(c => c.CPF)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}
