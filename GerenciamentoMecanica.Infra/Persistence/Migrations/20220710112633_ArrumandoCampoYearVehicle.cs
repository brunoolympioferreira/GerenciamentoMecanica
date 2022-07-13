using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoMecanica.Infra.Persistence.Migrations
{
    public partial class ArrumandoCampoYearVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "YearOfManufacture",
                table: "tb_vehicle",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfManufacture",
                table: "tb_vehicle",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
