using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class actualizacampos4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "Vendedor",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "Comprador",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "Comprador");
        }
    }
}
