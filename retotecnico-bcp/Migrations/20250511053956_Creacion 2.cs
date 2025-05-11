using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace retotecnico_bcp.Migrations
{
    /// <inheritdoc />
    public partial class Creacion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoCambios",
                columns: table => new
                {
                    inIdTipoCambio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    monedaOrigeninIdMoneda = table.Column<int>(type: "int", nullable: true),
                    monedaDestinoinIdMoneda = table.Column<int>(type: "int", nullable: true),
                    dcTipoCambio = table.Column<decimal>(type: "decimal(18,10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoCambios", x => x.inIdTipoCambio);
                    table.ForeignKey(
                        name: "FK_TipoCambios_Monedas_monedaDestinoinIdMoneda",
                        column: x => x.monedaDestinoinIdMoneda,
                        principalTable: "Monedas",
                        principalColumn: "inIdMoneda");
                    table.ForeignKey(
                        name: "FK_TipoCambios_Monedas_monedaOrigeninIdMoneda",
                        column: x => x.monedaOrigeninIdMoneda,
                        principalTable: "Monedas",
                        principalColumn: "inIdMoneda");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TipoCambios_monedaDestinoinIdMoneda",
                table: "TipoCambios",
                column: "monedaDestinoinIdMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_TipoCambios_monedaOrigeninIdMoneda",
                table: "TipoCambios",
                column: "monedaOrigeninIdMoneda");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoCambios");
        }
    }
}
