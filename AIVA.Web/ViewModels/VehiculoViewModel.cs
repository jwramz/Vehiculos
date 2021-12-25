using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIVA.Web.ViewModels
{
    public class VehiculoViewModel
    {
        public int id  { get; set; }

        //Datos registro vehiculo por agencia

        [DisplayName("Lugar de registro")]
        public int LugarRevision { get; set; }

        //[DisplayName("Fecha de registro")]
        //public DateTime fechaRegistroAgencia { get; set; }

        [DisplayName("Fecha")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaRegistroAgencia { get; set; }

        [DisplayName("Creado")]
        public DateTime FechaCreacion { get; set; }

        [DisplayName("Última actualización")]
        public DateTime UltimaActualizacion { get; set; }

        [DisplayName("Usuario")]
        public string UsuarioRegistro { get; set; }

        [DisplayName("Modificado por")]
        public DateTime UsuarioModifico { get; set; }

        [DisplayName("No. registro")]
        public int NoRegistro { get; set; }

        [DisplayName("Ficha")]
        public int Ficha { get; set; }

        //DATOS DEL VEHICULO

        [DisplayName("Número de serie")]
        public string NoSerie { get; set; }

        [DisplayName("Número de motor")]
        public string NoMotor { get; set; }

        [DisplayName("Marca")]
        public string Marca { get; set; }

        public int idMarca { get; set; }

        [DisplayName("Submarca")]
        public string SubMarca { get; set; }

        public int idSubMarca { get; set; }

        [DisplayName("Modelo")]
        public string Modelo { get; set; }

        public int idModelo { get; set; }

        [DisplayName("Año del modelo")]
        public string AModelo { get; set; }

        public int ModeloAnio { get; set; }

        [DisplayName("Color")]
        public string Color { get; set; }

        public int idColor { get; set; }

        [DisplayName("5 DIG")]
        public int CincoDigitos { get; set; }

        [DisplayName("No. placa")]
        public string Placa { get; set; }

        [DisplayName("Procedencia")]
        public int Procedencia { get; set; }

        [DisplayName("Estado")]
        public string EstadoProcedencia { get; set; }

        public int idEstado { get; set; }

        [DisplayName("País")]
        public string PaisProcedencia { get; set; }

        [DisplayName("Municipio")]
        public string MunicipioProcedencia { get; set; }

        public int idMunicipio;
        //Campos para las observaciones realizadas en el reporte del vehiculo 


        [DisplayName("Observaciones")]
        public string ObservacionesReporte { get; set; }

        //Datos para informes en documentos
        [DisplayName("Número de responsiva")]
        public int NumeroResponsiva { get; set; }

        [DisplayName("Número de dictamen")]
        public string NumeroDictamen { get; set; }

        [DisplayName("Número de recibo")]
        public int ReciboNumero { get; set; }

        [DisplayName("Recibio")]
        public string Recibio { get; set; }

        [DisplayName("Se debe")]
        public int CheckDebe { get; set; }

        [DisplayName("Pago")]
        public int Pago { get; set; }


        //Check para documentos apocrifos
        public int DocumentosAprocrifos { get; set; }


        //Check para numeración alterada
        public int NumeracionAlterada { get; set; }

        //Check box para reporte con robo o adeudos
        public int TipoReporte { get; set; }



        //Datos comprador
        public int idComprador { get; set; }

        [DisplayName("Nombre")]
        public string NombreComprador { get; set; }

        [DisplayName("Teléfono")]
        public string TelefonoComprador { get; set; }

        [DisplayName("Dirección")]
        public string DireccionComprador { get; set; }

        [DisplayName("Colonia")]
        public string ColoniaComprador { get; set; }

        [DisplayName("C.P.")]
        public string CPComprador { get; set; }

        [DisplayName("RFC")]
        public string RFCComprador { get; set; }

        //Datos comprador modal
        public int idCompradorModal { get; set; }

        [DisplayName("Nombre")]
        public string NombreCompradorModal { get; set; }

        [DisplayName("Teléfono")]
        public string TelefonoCompradorModal { get; set; }

        [DisplayName("Dirección")]
        public string DireccionCompradorModal { get; set; }

        [DisplayName("Colonia")]
        public string ColoniaCompradorModal { get; set; }

        [DisplayName("C.P.")]
        public string CPCompradorModal { get; set; }

        [DisplayName("RFC")]
        public string RFCCompradorModal { get; set; }


        // Datos vendedor
        public int idVendedor { get; set; }

        [DisplayName("Nombre")]
        public string NombreVendedor { get; set; }

        [DisplayName("Teléfono")]
        public string TelefonoVendedor { get; set; }


        [DisplayName("Dirección")]
        public string DireccionVendedor { get; set; }


        [DisplayName("Colonia")]
        public string ColoniaVendedor { get; set; }

        [DisplayName("C.P.")]
        public string CPVendedor { get; set; }

        [DisplayName("RFC")]
        public string RFCVendedor { get; set; }



        // Datos vendedor modal
        public int idVendedorModal { get; set; }

        [DisplayName("Nombre")]
        public string NombreVendedorModal { get; set; }

        [DisplayName("Teléfono")]
        public string TelefonoVendedorModal { get; set; }


        [DisplayName("Dirección")]
        public string DireccionVendedorModal { get; set; }


        [DisplayName("Colonia")]
        public string ColoniaVendedorModal { get; set; }

        [DisplayName("C.P.")]
        public string CPVendedorModal { get; set; }

        [DisplayName("RFC")]
        public string RFCVendedorModal { get; set; }





        //Datos adicionales de información de investigación
        [DisplayName("RFV")]
        public string RFV { get; set; }

        [DisplayName("Averiguación")]
        public string Averiguacion { get; set; }

        [DisplayName("Base")]
        public string BaseAveriguacion { get; set; }

        [DisplayName("Modus operandi")]
        public string ModusOperandi { get; set; }

        [DisplayName("Observaciones")]
        public string ObservacionReporteRegistro { get; set; }

        [DisplayName("Violencia")]
        public bool Violencia { get; set; }

        [DisplayName("Fecha")]
        public DateTime FechaRegistroReporte { get; set; }

        [DisplayName("Hora")]
        public string HoraregistroReporte { get; set; }

        [DisplayName("Lugar")]
        public string LugarReporte { get; set; }

        //Datos dictamen
        //factura
        [DisplayName("Factura de origen a nombre de ")]
        public string FacturaOrigen { get; set; }

        [DisplayName("Empresa que factura ")]
        public string EmpresaFactura { get; set; }

        [DisplayName("Fecha de factura ")]
        public DateTime FechaFactura { get; set; }

        [DisplayName("Valor de la factura $ ")]
        public int ValorFactura { get; set; }

        //Datos adicionales del vehiculo

        [DisplayName("Número de tablero ")]
        public bool NumeroTablero { get; set; }

        [DisplayName("Número de tablero ")]
        public bool NumGrabado { get; set; }

        [DisplayName("Número de motor ")]
        public bool EstatusNumeroMotor { get; set; }

        [DisplayName("Observaciones de númeración ")]
        public string ObservacionesNumeracion { get; set; }

        public List<Vehiculo> listaVehiculos { get; set; }

        public Vehiculo datosVehiculo { get; set; }


        //CAMPOS PARA LOS VALORES SELECCIONADOS DE LAS LISTAS 
        public int idAModelo { get; set; }
      
      
        //LISTAS 
        public List<SelectListItem> listaAModelos { get; set; }
        public List<SelectListItem> listaMunicipios { get; set; }
        public List<SelectListItem> listaEstados { get; set; }
        public List<SelectListItem> listaMarcas { get; set; }
        public List<SelectListItem> listaModelosAutos { get; set; }
        public List<SelectListItem> listaColores { get; set; }

        public List<SelectListItem> listaOficinas { get; set; }

        public Vendedor VendedorDatos { get; set; }
        public Comprador CompradorDatos { get; set; }


        public List<Vendedor> ListaVendedores { get; set; }
     
        public List<Comprador> ListaCompradores { get; set; }

        public List<ReporteVehiculo> VehiculosReportados { get; set; }

        //Busqueda 

        [DisplayName("Fecha inicio")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }

        [DisplayName("Fecha término")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaTermino { get; set; }


        public bool NuevoRegistro { get; set; }
    }
}
