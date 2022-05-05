﻿// <auto-generated />
using System;
using GerenciamentoMecanica.Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciamentoMecanica.Infra.Persistence.Migrations
{
    [DbContext(typeof(GerenciamentoMecanicaDbContext))]
    [Migration("20220505183232_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Complement")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.HasKey("Id");

                    b.ToTable("tb_address");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("tb_client");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AdmissionDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("BirthdayDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CarteiraTrabalho")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<DateTime?>("EmployeeLeave")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FinishVacation")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Function")
                        .HasColumnType("int");

                    b.Property<string>("Pis")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Reservista")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ResignationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("tb_employee");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdClient")
                        .HasColumnType("int");

                    b.Property<int>("IdVehicle")
                        .HasColumnType("int");

                    b.Property<DateTime>("InputData")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("OutputData")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceDescription")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("ServiceStatus")
                        .HasColumnType("int");

                    b.Property<decimal?>("TotalCost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdatedData")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.HasIndex("IdVehicle");

                    b.ToTable("tb_service");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<int>("Manufacturer")
                        .HasColumnType("int");

                    b.Property<DateTime>("YearOfManufacture")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("tb_vehicle");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Client", b =>
                {
                    b.HasOne("GerenciamentoMecanica.Core.Entities.Address", "Address")
                        .WithOne("Client")
                        .HasForeignKey("GerenciamentoMecanica.Core.Entities.Client", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Employee", b =>
                {
                    b.HasOne("GerenciamentoMecanica.Core.Entities.Address", "Address")
                        .WithOne("Employee")
                        .HasForeignKey("GerenciamentoMecanica.Core.Entities.Employee", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Service", b =>
                {
                    b.HasOne("GerenciamentoMecanica.Core.Entities.Client", "Client")
                        .WithMany("Services")
                        .HasForeignKey("IdClient")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GerenciamentoMecanica.Core.Entities.Vehicle", "Vehicle")
                        .WithMany("Services")
                        .HasForeignKey("IdVehicle")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Vehicle", b =>
                {
                    b.HasOne("GerenciamentoMecanica.Core.Entities.Client", "Client")
                        .WithMany("Vehicles")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Address", b =>
                {
                    b.Navigation("Client");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Client", b =>
                {
                    b.Navigation("Services");

                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("GerenciamentoMecanica.Core.Entities.Vehicle", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
