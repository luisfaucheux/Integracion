using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProyectoLibreria.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    ApellidoPaterno = table.Column<string>(nullable: true),
                    ApellidoMaterno = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    DNI = table.Column<int>(nullable: false),
                    RUC = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "sede",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sede", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_clienteID = table.Column<int>(nullable: false),
                    ID_sedeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.ID);
                    table.ForeignKey(
                        name: "FK_facturas_clientes_ID_clienteID",
                        column: x => x.ID_clienteID,
                        principalTable: "clientes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_facturas_sede_ID_sedeID",
                        column: x => x.ID_sedeID,
                        principalTable: "sede",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "libro",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(nullable: false),
                    Año = table.Column<int>(nullable: false),
                    Autor = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    facturaID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_libro", x => x.ID);
                    table.ForeignKey(
                        name: "FK_libro_facturas_facturaID",
                        column: x => x.facturaID,
                        principalTable: "facturas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_facturas_ID_clienteID",
                table: "facturas",
                column: "ID_clienteID");

            migrationBuilder.CreateIndex(
                name: "IX_facturas_ID_sedeID",
                table: "facturas",
                column: "ID_sedeID");

            migrationBuilder.CreateIndex(
                name: "IX_libro_facturaID",
                table: "libro",
                column: "facturaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "libro");

            migrationBuilder.DropTable(
                name: "facturas");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "sede");
        }
    }
}
