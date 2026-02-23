using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Actividad1.Migrations
{
    /// <inheritdoc />
    public partial class AgregarPanaderia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Panaderias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panaderias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PanaderiaProductos",
                columns: table => new
                {
                    PanaderiaId = table.Column<int>(type: "int", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanaderiaProductos", x => new { x.PanaderiaId, x.ProductoId });
                    table.ForeignKey(
                        name: "FK_PanaderiaProductos_Panaderias_PanaderiaId",
                        column: x => x.PanaderiaId,
                        principalTable: "Panaderias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PanaderiaProductos_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PanaderiaProductos_ProductoId",
                table: "PanaderiaProductos",
                column: "ProductoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PanaderiaProductos");

            migrationBuilder.DropTable(
                name: "Panaderias");
        }
    }
}
