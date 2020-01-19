using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoLibreria.Migrations
{
    public partial class Factura : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_facturas_clientes_ID_clienteID",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_facturas_sede_ID_sedeID",
                table: "facturas");

            migrationBuilder.RenameColumn(
                name: "ID_sedeID",
                table: "facturas",
                newName: "SedeID");

            migrationBuilder.RenameColumn(
                name: "ID_clienteID",
                table: "facturas",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_facturas_ID_sedeID",
                table: "facturas",
                newName: "IX_facturas_SedeID");

            migrationBuilder.RenameIndex(
                name: "IX_facturas_ID_clienteID",
                table: "facturas",
                newName: "IX_facturas_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_clientes_ClienteID",
                table: "facturas",
                column: "ClienteID",
                principalTable: "clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_sede_SedeID",
                table: "facturas",
                column: "SedeID",
                principalTable: "sede",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_facturas_clientes_ClienteID",
                table: "facturas");

            migrationBuilder.DropForeignKey(
                name: "FK_facturas_sede_SedeID",
                table: "facturas");

            migrationBuilder.RenameColumn(
                name: "SedeID",
                table: "facturas",
                newName: "ID_sedeID");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "facturas",
                newName: "ID_clienteID");

            migrationBuilder.RenameIndex(
                name: "IX_facturas_SedeID",
                table: "facturas",
                newName: "IX_facturas_ID_sedeID");

            migrationBuilder.RenameIndex(
                name: "IX_facturas_ClienteID",
                table: "facturas",
                newName: "IX_facturas_ID_clienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_clientes_ID_clienteID",
                table: "facturas",
                column: "ID_clienteID",
                principalTable: "clientes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_facturas_sede_ID_sedeID",
                table: "facturas",
                column: "ID_sedeID",
                principalTable: "sede",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
