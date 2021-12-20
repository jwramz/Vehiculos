using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class testClienteactualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Municipio",
                table: "Cliente",
                newName: "IVA");

            migrationBuilder.AddColumn<string>(
                name: "HorarioPorDefecto",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ISR",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Municipioid",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idMunicipio",
                table: "Cliente",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Municipioid",
                table: "Cliente",
                column: "Municipioid");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Municipio_Municipioid",
                table: "Cliente",
                column: "Municipioid",
                principalTable: "Municipio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Municipio_Municipioid",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_Municipioid",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "HorarioPorDefecto",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ISR",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Municipioid",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "idMunicipio",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "IVA",
                table: "Cliente",
                newName: "Municipio");
        }
    }
}
