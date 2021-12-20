using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class actualizacionVehiculos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "Vehiculo",
                newName: "idVendedor");

            migrationBuilder.RenameColumn(
                name: "AModelo",
                table: "Vehiculo",
                newName: "idSubMarca");

            migrationBuilder.AlterColumn<string>(
                name: "Estado",
                table: "Vehiculo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "Vehiculo",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CheckDebe",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentosAprocrifos",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Ficha",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LugarRevision",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeracionAlterada",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumeroResponsiva",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Observaciones",
                table: "Vehiculo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Pago",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recibio",
                table: "Vehiculo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReciboNumero",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TipoReporte",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioRegistro",
                table: "Vehiculo",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idColor",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idComprador",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idEstado",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idMarca",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idModelo",
                table: "Vehiculo",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idPais",
                table: "Vehiculo",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckDebe",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "DocumentosAprocrifos",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Ficha",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "LugarRevision",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "NumeracionAlterada",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "NumeroResponsiva",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Observaciones",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Pago",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "Recibio",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "ReciboNumero",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "TipoReporte",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "UsuarioRegistro",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "idColor",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "idComprador",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "idEstado",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "idMarca",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "idModelo",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "idPais",
                table: "Vehiculo");

            migrationBuilder.RenameColumn(
                name: "idVendedor",
                table: "Vehiculo",
                newName: "Pais");

            migrationBuilder.RenameColumn(
                name: "idSubMarca",
                table: "Vehiculo",
                newName: "AModelo");

            migrationBuilder.AlterColumn<int>(
                name: "Estado",
                table: "Vehiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Color",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
