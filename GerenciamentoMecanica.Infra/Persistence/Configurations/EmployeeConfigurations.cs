using GerenciamentoMecanica.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoMecanica.Infra.Persistence.Configurations
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("tb_employee");

            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(e => e.BirthdayDate)
                .IsRequired();

            builder
                .Property(e => e.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(e => e.Rg)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(e => e.CarteiraTrabalho)
                .IsRequired()
                .HasMaxLength(8);

            builder
                .Property(e => e.Cpf)
                .IsRequired()
                .HasMaxLength(11);

            builder
                .Property(e => e.Pis)
                .IsRequired()
                .HasMaxLength(12);

            builder
               .Property(e => e.Function)
               .IsRequired();

            builder
               .Property(e => e.AdmissionDate)
               .IsRequired();

            builder
               .Property(e => e.EmployeeStatus)
               .IsRequired();


        }
    }
}
