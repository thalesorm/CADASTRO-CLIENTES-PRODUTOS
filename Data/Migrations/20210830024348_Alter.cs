using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Alter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Clientes_ClienteIdCliente",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ClienteIdCliente",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "ClienteIdCliente",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Produtos",
                newName: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClienteId",
                table: "Produtos",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Clientes_ClienteId",
                table: "Produtos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Clientes_ClienteId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_ClienteId",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Produtos",
                newName: "IdCliente");

            migrationBuilder.AddColumn<int>(
                name: "ClienteIdCliente",
                table: "Produtos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClienteIdCliente",
                table: "Produtos",
                column: "ClienteIdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Clientes_ClienteIdCliente",
                table: "Produtos",
                column: "ClienteIdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
