using Microsoft.EntityFrameworkCore.Migrations;

namespace Cotizador_Celebraciones.Migrations
{
    public partial class Lugar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cliente",
                table: "Cotizacion",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Lugar",
                table: "Cotizacion",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cliente",
                table: "Cotizacion");

            migrationBuilder.DropColumn(
                name: "Lugar",
                table: "Cotizacion");
        }
    }
}
