using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class test6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idMarcaVehiculo",
                table: "Modelo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Estado",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estado", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Municipio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    idEstado = table.Column<int>(type: "int", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estatus = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Municipio", x => x.id);
                    table.ForeignKey(
                        name: "FK_Municipio_Estado_idEstado",
                        column: x => x.idEstado,
                        principalTable: "Estado",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_idMarcaVehiculo",
                table: "Modelo",
                column: "idMarcaVehiculo");

            migrationBuilder.CreateIndex(
                name: "IX_Municipio_idEstado",
                table: "Municipio",
                column: "idEstado");

            migrationBuilder.AddForeignKey(
                name: "FK_Modelo_Marca_idMarcaVehiculo",
                table: "Modelo",
                column: "idMarcaVehiculo",
                principalTable: "Marca",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modelo_Marca_idMarcaVehiculo",
                table: "Modelo");

            migrationBuilder.DropTable(
                name: "Municipio");

            migrationBuilder.DropTable(
                name: "Estado");

            migrationBuilder.DropIndex(
                name: "IX_Modelo_idMarcaVehiculo",
                table: "Modelo");

            migrationBuilder.DropColumn(
                name: "idMarcaVehiculo",
                table: "Modelo");
        }
    }
}
