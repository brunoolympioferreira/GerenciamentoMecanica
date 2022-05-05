using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoMecanica.Infra.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Street = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Complement = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    District = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    State = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_client",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_client", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_client_tb_address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "tb_address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthdayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Cpf = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    Rg = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CarteiraTrabalho = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    Pis = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Reservista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Function = table.Column<int>(type: "int", nullable: false),
                    AdmissionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResignationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FinishVacation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeLeave = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmployeeStatus = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_employee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_employee_tb_address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "tb_address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    YearOfManufacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LicensePlate = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_vehicle_tb_client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "tb_client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_service",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceDescription = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    InputData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OutputData = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ServiceStatus = table.Column<int>(type: "int", nullable: false),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdVehicle = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_service", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_service_tb_client_IdClient",
                        column: x => x.IdClient,
                        principalTable: "tb_client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_service_tb_vehicle_IdVehicle",
                        column: x => x.IdVehicle,
                        principalTable: "tb_vehicle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_client_AddressId",
                table: "tb_client",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_employee_AddressId",
                table: "tb_employee",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_service_IdClient",
                table: "tb_service",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_tb_service_IdVehicle",
                table: "tb_service",
                column: "IdVehicle");

            migrationBuilder.CreateIndex(
                name: "IX_tb_vehicle_ClientId",
                table: "tb_vehicle",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_employee");

            migrationBuilder.DropTable(
                name: "tb_service");

            migrationBuilder.DropTable(
                name: "tb_vehicle");

            migrationBuilder.DropTable(
                name: "tb_client");

            migrationBuilder.DropTable(
                name: "tb_address");
        }
    }
}
