using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class actualizacionTablaVehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_idColor",
                table: "Vehiculo",
                column: "idColor");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_idComprador",
                table: "Vehiculo",
                column: "idComprador");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_idEstado",
                table: "Vehiculo",
                column: "idEstado");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_idMarca",
                table: "Vehiculo",
                column: "idMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_idModelo",
                table: "Vehiculo",
                column: "idModelo");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_idSubMarca",
                table: "Vehiculo",
                column: "idSubMarca");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculo_idVendedor",
                table: "Vehiculo",
                column: "idVendedor");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_AModelo_idModelo",
                table: "Vehiculo",
                column: "idModelo",
                principalTable: "AModelo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Comprador_idComprador",
                table: "Vehiculo",
                column: "idComprador",
                principalTable: "Comprador",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Estado_idEstado",
                table: "Vehiculo",
                column: "idEstado",
                principalTable: "Estado",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Marca_idMarca",
                table: "Vehiculo",
                column: "idMarca",
                principalTable: "Marca",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Modelo_idSubMarca",
                table: "Vehiculo",
                column: "idSubMarca",
                principalTable: "Modelo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_PinturaVehiculo_idColor",
                table: "Vehiculo",
                column: "idColor",
                principalTable: "PinturaVehiculo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculo_Vendedor_idVendedor",
                table: "Vehiculo",
                column: "idVendedor",
                principalTable: "Vendedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_AModelo_idModelo",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Comprador_idComprador",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Estado_idEstado",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Marca_idMarca",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Modelo_idSubMarca",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_PinturaVehiculo_idColor",
                table: "Vehiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculo_Vendedor_idVendedor",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_idColor",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_idComprador",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_idEstado",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_idMarca",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_idModelo",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_idSubMarca",
                table: "Vehiculo");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculo_idVendedor",
                table: "Vehiculo");

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
    }
}
