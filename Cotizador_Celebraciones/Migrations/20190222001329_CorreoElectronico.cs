using Microsoft.EntityFrameworkCore.Migrations;

namespace Cotizador_Celebraciones.Migrations
{
    public partial class CorreoElectronico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NombreEvento",
                table: "Cotizacion",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CorreoElectronico",
                table: "Cotizacion",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorreoElectronico",
                table: "Cotizacion");

            migrationBuilder.AlterColumn<string>(
                name: "NombreEvento",
                table: "Cotizacion",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
