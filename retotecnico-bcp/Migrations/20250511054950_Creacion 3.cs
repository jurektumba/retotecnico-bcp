using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace retotecnico_bcp.Migrations
{
    /// <inheritdoc />
    public partial class Creacion3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoCambios_Monedas_monedaDestinoinIdMoneda",
                table: "TipoCambios");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoCambios_Monedas_monedaOrigeninIdMoneda",
                table: "TipoCambios");

            migrationBuilder.AlterColumn<int>(
                name: "monedaOrigeninIdMoneda",
                table: "TipoCambios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "monedaDestinoinIdMoneda",
                table: "TipoCambios",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoCambios_Monedas_monedaDestinoinIdMoneda",
                table: "TipoCambios",
                column: "monedaDestinoinIdMoneda",
                principalTable: "Monedas",
                principalColumn: "inIdMoneda",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoCambios_Monedas_monedaOrigeninIdMoneda",
                table: "TipoCambios",
                column: "monedaOrigeninIdMoneda",
                principalTable: "Monedas",
                principalColumn: "inIdMoneda",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoCambios_Monedas_monedaDestinoinIdMoneda",
                table: "TipoCambios");

            migrationBuilder.DropForeignKey(
                name: "FK_TipoCambios_Monedas_monedaOrigeninIdMoneda",
                table: "TipoCambios");

            migrationBuilder.AlterColumn<int>(
                name: "monedaOrigeninIdMoneda",
                table: "TipoCambios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "monedaDestinoinIdMoneda",
                table: "TipoCambios",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoCambios_Monedas_monedaDestinoinIdMoneda",
                table: "TipoCambios",
                column: "monedaDestinoinIdMoneda",
                principalTable: "Monedas",
                principalColumn: "inIdMoneda");

            migrationBuilder.AddForeignKey(
                name: "FK_TipoCambios_Monedas_monedaOrigeninIdMoneda",
                table: "TipoCambios",
                column: "monedaOrigeninIdMoneda",
                principalTable: "Monedas",
                principalColumn: "inIdMoneda");
        }
    }
}
