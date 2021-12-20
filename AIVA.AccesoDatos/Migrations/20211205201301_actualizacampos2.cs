using Microsoft.EntityFrameworkCore.Migrations;

namespace AIVA.AccesoDatos.Migrations
{
    public partial class actualizacampos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "valoridentificacion",
                table: "Vendedor",
                newName: "ValorIdentificacion");

            migrationBuilder.RenameColumn(
                name: "tipoidentificacion",
                table: "Vendedor",
                newName: "TipoIdentificacion");

            migrationBuilder.RenameColumn(
                name: "rfc",
                table: "Vendedor",
                newName: "RFC");

            migrationBuilder.RenameColumn(
                name: "notelefono",
                table: "Vendedor",
                newName: "NoTelefono");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Vendedor",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "nocelular",
                table: "Vendedor",
                newName: "NoCelular");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "Vendedor",
                newName: "FechaRegistro");

            migrationBuilder.RenameColumn(
                name: "estatus",
                table: "Vendedor",
                newName: "Estatus");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Vendedor",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "colonia",
                table: "Vendedor",
                newName: "Colonia");

            migrationBuilder.RenameColumn(
                name: "tipovehiculo",
                table: "Vehiculo",
                newName: "TipoVehiculo");

            migrationBuilder.RenameColumn(
                name: "submarca",
                table: "Vehiculo",
                newName: "SubMarca");

            migrationBuilder.RenameColumn(
                name: "pais",
                table: "Vehiculo",
                newName: "Pais");

            migrationBuilder.RenameColumn(
                name: "noserie",
                table: "Vehiculo",
                newName: "NoSerie");

            migrationBuilder.RenameColumn(
                name: "noplaca",
                table: "Vehiculo",
                newName: "NoPlaca");

            migrationBuilder.RenameColumn(
                name: "nomotor",
                table: "Vehiculo",
                newName: "NoMotor");

            migrationBuilder.RenameColumn(
                name: "modelo",
                table: "Vehiculo",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Vehiculo",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "Vehiculo",
                newName: "FechaRegistro");

            migrationBuilder.RenameColumn(
                name: "estatus",
                table: "Vehiculo",
                newName: "Estatus");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Vehiculo",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "Vehiculo",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "amodelo",
                table: "Vehiculo",
                newName: "AModelo");

            migrationBuilder.RenameColumn(
                name: "valoridentificacion",
                table: "Comprador",
                newName: "ValorIdentificacion");

            migrationBuilder.RenameColumn(
                name: "tipoidentificacion",
                table: "Comprador",
                newName: "TipoIdentificacion");

            migrationBuilder.RenameColumn(
                name: "rfc",
                table: "Comprador",
                newName: "RFC");

            migrationBuilder.RenameColumn(
                name: "notelefono",
                table: "Comprador",
                newName: "NoTelefono");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Comprador",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "nocelular",
                table: "Comprador",
                newName: "NoCelular");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "Comprador",
                newName: "FechaRegistro");

            migrationBuilder.RenameColumn(
                name: "estatus",
                table: "Comprador",
                newName: "Estatus");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Comprador",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "colonia",
                table: "Comprador",
                newName: "Colonia");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "Cliente",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "rfc",
                table: "Cliente",
                newName: "RFC");

            migrationBuilder.RenameColumn(
                name: "razonsocial",
                table: "Cliente",
                newName: "RazonSocial");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Cliente",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "nocelular",
                table: "Cliente",
                newName: "NoCelular");

            migrationBuilder.RenameColumn(
                name: "municipio",
                table: "Cliente",
                newName: "Municipio");

            migrationBuilder.RenameColumn(
                name: "fechaRegistro",
                table: "Cliente",
                newName: "FechaRegistro");

            migrationBuilder.RenameColumn(
                name: "estatus",
                table: "Cliente",
                newName: "Estatus");

            migrationBuilder.RenameColumn(
                name: "estado",
                table: "Cliente",
                newName: "Estado");

            migrationBuilder.RenameColumn(
                name: "domicilio",
                table: "Cliente",
                newName: "Domicilio");

            migrationBuilder.RenameColumn(
                name: "colonia",
                table: "Cliente",
                newName: "Colonia");

            migrationBuilder.RenameColumn(
                name: "codigopostal",
                table: "Cliente",
                newName: "CodigoPostal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorIdentificacion",
                table: "Vendedor",
                newName: "valoridentificacion");

            migrationBuilder.RenameColumn(
                name: "TipoIdentificacion",
                table: "Vendedor",
                newName: "tipoidentificacion");

            migrationBuilder.RenameColumn(
                name: "RFC",
                table: "Vendedor",
                newName: "rfc");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Vendedor",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "NoTelefono",
                table: "Vendedor",
                newName: "notelefono");

            migrationBuilder.RenameColumn(
                name: "NoCelular",
                table: "Vendedor",
                newName: "nocelular");

            migrationBuilder.RenameColumn(
                name: "FechaRegistro",
                table: "Vendedor",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "Estatus",
                table: "Vendedor",
                newName: "estatus");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Vendedor",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Colonia",
                table: "Vendedor",
                newName: "colonia");

            migrationBuilder.RenameColumn(
                name: "TipoVehiculo",
                table: "Vehiculo",
                newName: "tipovehiculo");

            migrationBuilder.RenameColumn(
                name: "SubMarca",
                table: "Vehiculo",
                newName: "submarca");

            migrationBuilder.RenameColumn(
                name: "Pais",
                table: "Vehiculo",
                newName: "pais");

            migrationBuilder.RenameColumn(
                name: "NoSerie",
                table: "Vehiculo",
                newName: "noserie");

            migrationBuilder.RenameColumn(
                name: "NoPlaca",
                table: "Vehiculo",
                newName: "noplaca");

            migrationBuilder.RenameColumn(
                name: "NoMotor",
                table: "Vehiculo",
                newName: "nomotor");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Vehiculo",
                newName: "modelo");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Vehiculo",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "FechaRegistro",
                table: "Vehiculo",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "Estatus",
                table: "Vehiculo",
                newName: "estatus");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Vehiculo",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Vehiculo",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "AModelo",
                table: "Vehiculo",
                newName: "amodelo");

            migrationBuilder.RenameColumn(
                name: "ValorIdentificacion",
                table: "Comprador",
                newName: "valoridentificacion");

            migrationBuilder.RenameColumn(
                name: "TipoIdentificacion",
                table: "Comprador",
                newName: "tipoidentificacion");

            migrationBuilder.RenameColumn(
                name: "RFC",
                table: "Comprador",
                newName: "rfc");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Comprador",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "NoTelefono",
                table: "Comprador",
                newName: "notelefono");

            migrationBuilder.RenameColumn(
                name: "NoCelular",
                table: "Comprador",
                newName: "nocelular");

            migrationBuilder.RenameColumn(
                name: "FechaRegistro",
                table: "Comprador",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "Estatus",
                table: "Comprador",
                newName: "estatus");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Comprador",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Colonia",
                table: "Comprador",
                newName: "colonia");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Cliente",
                newName: "telefono");

            migrationBuilder.RenameColumn(
                name: "RazonSocial",
                table: "Cliente",
                newName: "razonsocial");

            migrationBuilder.RenameColumn(
                name: "RFC",
                table: "Cliente",
                newName: "rfc");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Cliente",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "NoCelular",
                table: "Cliente",
                newName: "nocelular");

            migrationBuilder.RenameColumn(
                name: "Municipio",
                table: "Cliente",
                newName: "municipio");

            migrationBuilder.RenameColumn(
                name: "FechaRegistro",
                table: "Cliente",
                newName: "fechaRegistro");

            migrationBuilder.RenameColumn(
                name: "Estatus",
                table: "Cliente",
                newName: "estatus");

            migrationBuilder.RenameColumn(
                name: "Estado",
                table: "Cliente",
                newName: "estado");

            migrationBuilder.RenameColumn(
                name: "Domicilio",
                table: "Cliente",
                newName: "domicilio");

            migrationBuilder.RenameColumn(
                name: "Colonia",
                table: "Cliente",
                newName: "colonia");

            migrationBuilder.RenameColumn(
                name: "CodigoPostal",
                table: "Cliente",
                newName: "codigopostal");
        }
    }
}
