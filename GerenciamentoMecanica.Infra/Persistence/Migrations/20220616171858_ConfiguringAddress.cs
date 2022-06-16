using Microsoft.EntityFrameworkCore.Migrations;

namespace GerenciamentoMecanica.Infra.Persistence.Migrations
{
    public partial class ConfiguringAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_client_tb_address_AddressId",
                table: "tb_client");

            migrationBuilder.DropIndex(
                name: "IX_tb_client_AddressId",
                table: "tb_client");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "tb_client");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "tb_address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_address_ClientId",
                table: "tb_address",
                column: "ClientId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_address_tb_client_ClientId",
                table: "tb_address",
                column: "ClientId",
                principalTable: "tb_client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_address_tb_client_ClientId",
                table: "tb_address");

            migrationBuilder.DropIndex(
                name: "IX_tb_address_ClientId",
                table: "tb_address");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "tb_address");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "tb_client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tb_client_AddressId",
                table: "tb_client",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_client_tb_address_AddressId",
                table: "tb_client",
                column: "AddressId",
                principalTable: "tb_address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
