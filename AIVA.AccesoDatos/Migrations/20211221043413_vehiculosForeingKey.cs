using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class vehiculosForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AnioModeloVehiculoid",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColoresVehiculoid",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadoOrigenid",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MarcaVehiculoid",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubMarcaVehiculoid",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_AnioModeloVehiculoid",
                table: "Vehiculo",
                column: "AnioModeloVehiculoid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_ColoresVehiculoid",
                table: "Vehiculo",
                column: "ColoresVehiculoid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_EstadoOrigenid",
                table: "Vehiculo",
                column: "EstadoOrigenid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_MarcaVehiculoid",
                table: "Vehiculo",
                column: "MarcaVehiculoid");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_SubMarcaVehiculoid",
                table: "Vehiculo",
                column: "SubMarcaVehiculoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_AModelo_AnioModeloVehiculoid",
                table: "Vehiculo",
                column: "AnioModeloVehiculoid",
                principalTable: "AModelo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Estado_EstadoOrigenid",
                table: "Vehiculo",
                column: "EstadoOrigenid",
                principalTable: "Estado",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Marca_MarcaVehiculoid",
                table: "Vehiculo",
                column: "MarcaVehiculoid",
                principalTable: "Marca",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelo_SubMarcaVehiculoid",
                table: "Vehiculo",
                column: "SubMarcaVehiculoid",
                principalTable: "Modelo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_PinturaVehiculo_ColoresVehiculoid",
                table: "Vehiculo",
                column: "ColoresVehiculoid",
                principalTable: "PinturaVehiculo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_AModelo_AnioModeloVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Estado_EstadoOrigenid",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Marca_MarcaVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelo_SubMarcaVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_PinturaVehiculo_ColoresVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_AnioModeloVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_ColoresVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_EstadoOrigenid",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_MarcaVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_SubMarcaVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "AnioModeloVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "ColoresVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "EstadoOrigenid",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "MarcaVehiculoid",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "SubMarcaVehiculoid",
                table: "Vehiculo");
        }
    }
}
