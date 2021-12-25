using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class actualizacionTablaVehiculosOficina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_LugarRevision",
                table: "Vehiculo",
                column: "LugarRevision");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Oficina_LugarRevision",
                table: "Vehiculo",
                column: "LugarRevision",
                principalTable: "Oficina",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Oficina_LugarRevision",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_LugarRevision",
                table: "Vehiculo");
        }
    }
}
