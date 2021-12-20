using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class actualizacampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estado",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "Comprador");

            migrationBuilder.RenameColumn(
                name: "fecharegistro",
                table: "Vendedor",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "fecharegistro",
                table: "Comprador",
                newName: "fechaRegistro");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaRegistro",
                table: "Vendedor",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "estatus",
                table: "Vendedor",
                type: "bit",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "tipovehiculo",
                table: "Vehiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "pais",
                table: "Vehiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "estado",
                table: "Vehiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "amodelo",
                table: "Vehiculo",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "estatus",
                table: "Vehiculo",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaRegistro",
                table: "Vehiculo",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaRegistro",
                table: "Comprador",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<bool>(
                name: "estatus",
                table: "Comprador",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "estatus",
                table: "Cliente",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaRegistro",
                table: "Cliente",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "estatus",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "estatus",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "fechaRegistro",
                table: "Vehiculo");

            migrationBuilder.DropColumn(
                name: "estatus",
                table: "Comprador");

            migrationBuilder.DropColumn(
                name: "estatus",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "fechaRegistro",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "Vendedor",
                newName: "fecharegistro");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "Comprador",
                newName: "fecharegistro");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecharegistro",
                table: "Vendedor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "estado",
                table: "Vendedor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "tipovehiculo",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "pais",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "estado",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "amodelo",
                table: "Vehiculo",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fecharegistro",
                table: "Comprador",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "estado",
                table: "Comprador",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
