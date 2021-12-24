using AIVA.AccesoDatos.Data.Interfaces;
using AIVA.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIVA.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class VehiculosController : Controller
    {

        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public VehiculosController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            VehiculoViewModel vehiculo = new VehiculoViewModel();
            vehiculo.listaVehiculos = _contenedorTrabajo.Vehiculo.GetVehiculos();

            return View(vehiculo);
        }

        [HttpGet]
        public IActionResult Create()
        {
            VehiculoViewModel vehiculo = new VehiculoViewModel();

            vehiculo.listaColores = _contenedorTrabajo.Vehiculo.GetListaColorVehiculo();
            vehiculo.listaEstados = _contenedorTrabajo.Vehiculo.GetListaEstados();
            vehiculo.listaAModelos = _contenedorTrabajo.Vehiculo.GetListaAModelo();
            vehiculo.listaMarcas = _contenedorTrabajo.Vehiculo.GetListaMarcas();
            vehiculo.listaModelosAutos = _contenedorTrabajo.Vehiculo.GetListaModelos();
            vehiculo.listaMunicipios = _contenedorTrabajo.Vehiculo.GetListaMunicipios();
            vehiculo.listaOficinas = _contenedorTrabajo.Oficina.GetListaOficinas();

            vehiculo.FechaRegistroAgencia = DateTime.Now;

            return View(vehiculo);
        }

        [HttpPost]
        public IActionResult Create(VehiculoViewModel model)
        {
            model.datosVehiculo = new Modelos.Models.Vehiculo();

            model.datosVehiculo.FechaRegistro = model.FechaRegistroAgencia;

            model.datosVehiculo.Marca = model.Marca;
            model.datosVehiculo.idMarca = model.idMarca;

            model.datosVehiculo.SubMarca = model.SubMarca;
            model.datosVehiculo.idSubMarca = model.idSubMarca;

            model.datosVehiculo.Modelo = model.Modelo;
            model.datosVehiculo.idModelo = model.idModelo;

            model.datosVehiculo.Color = model.Color;
            model.datosVehiculo.idColor = model.idColor;

            model.datosVehiculo.NoSerie = model.NoSerie;
            model.datosVehiculo.NoPlaca = model.Placa;
            model.datosVehiculo.NoMotor = model.NoMotor;

            model.datosVehiculo.TipoVehiculo = 0;

            model.datosVehiculo.Estado = model.EstadoProcedencia;
            model.datosVehiculo.idEstado = model.idEstado;

            model.datosVehiculo.idPais = 0;
            model.datosVehiculo.idComprador = model.idComprador;
            model.datosVehiculo.idVendedor = model.idVendedor;

            model.datosVehiculo.Observaciones = model.ObservacionReporteRegistro;
            model.datosVehiculo.TipoReporte = model.TipoReporte;
            model.datosVehiculo.DocumentosAprocrifos = model.DocumentosAprocrifos;
            model.datosVehiculo.NumeracionAlterada = model.NumeracionAlterada;
            model.datosVehiculo.ReciboNumero = model.ReciboNumero;
            model.datosVehiculo.Recibio = model.Recibio;
            model.datosVehiculo.Pago = model.Pago;
            model.datosVehiculo.NumeroResponsiva = model.NumeroResponsiva;
            model.datosVehiculo.LugarRevision = model.LugarRevision;
            model.datosVehiculo.UsuarioRegistro = model.UsuarioRegistro;
                                
            
            bool resultado =  _contenedorTrabajo.Vehiculo.Create(model.datosVehiculo);
            _contenedorTrabajo.Save();


            if (resultado)
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Datos registrados con éxito";
                TempData["TipoMensaje"] = "success";

                model.listaColores = _contenedorTrabajo.Vehiculo.GetListaColorVehiculo();
                model.listaEstados = _contenedorTrabajo.Vehiculo.GetListaEstados();
                model.listaAModelos = _contenedorTrabajo.Vehiculo.GetListaAModelo();
                model.listaMarcas = _contenedorTrabajo.Vehiculo.GetListaMarcas();
                model.listaModelosAutos = _contenedorTrabajo.Vehiculo.GetListaModelos();
                model.listaMunicipios = _contenedorTrabajo.Vehiculo.GetListaMunicipios();
                model.listaOficinas = _contenedorTrabajo.Oficina.GetListaOficinas();

                model.FechaRegistroAgencia = DateTime.Now;
            }
            else
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Error en el registro de los datos del vehiculo";
                TempData["TipoMensaje"] = "warning";

                model.listaColores = _contenedorTrabajo.Vehiculo.GetListaColorVehiculo();
                model.listaEstados = _contenedorTrabajo.Vehiculo.GetListaEstados();
                model.listaAModelos = _contenedorTrabajo.Vehiculo.GetListaAModelo();
                model.listaMarcas = _contenedorTrabajo.Vehiculo.GetListaMarcas();
                model.listaModelosAutos = _contenedorTrabajo.Vehiculo.GetListaModelos();
                model.listaMunicipios = _contenedorTrabajo.Vehiculo.GetListaMunicipios();
                model.listaOficinas = _contenedorTrabajo.Oficina.GetListaOficinas();

                model.FechaRegistroAgencia = DateTime.Now;
            }



            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            VehiculoViewModel vehiculo = new VehiculoViewModel();
            return View(vehiculo);
        }

        [HttpPost]
        public IActionResult Edit(VehiculoViewModel model)
        {
            model.datosVehiculo.id = model.id;
            model.datosVehiculo.Marca = model.Marca;
            model.datosVehiculo.idMarca = model.idMarca;

            model.datosVehiculo.SubMarca = model.SubMarca;
            model.datosVehiculo.idSubMarca = model.idSubMarca;

            model.datosVehiculo.Modelo = model.Modelo;
            model.datosVehiculo.idModelo = model.idModelo;

            model.datosVehiculo.Color = model.Color;
            model.datosVehiculo.idColor = model.idColor;

            model.datosVehiculo.NoSerie = model.NoSerie;
            model.datosVehiculo.NoPlaca = model.Placa;
            model.datosVehiculo.NoMotor = model.NoMotor;

            model.datosVehiculo.TipoVehiculo = 0;

            model.datosVehiculo.Estado = model.EstadoProcedencia;
            model.datosVehiculo.idEstado = model.idEstado;

            model.datosVehiculo.idPais = 0;
            model.datosVehiculo.idComprador = model.idComprador;
            model.datosVehiculo.idVendedor = model.idVendedor;

            model.datosVehiculo.Observaciones = model.ObservacionReporteRegistro;
            model.datosVehiculo.TipoReporte = model.TipoReporte;
            model.datosVehiculo.DocumentosAprocrifos = model.DocumentosAprocrifos;
            model.datosVehiculo.NumeracionAlterada = model.NumeracionAlterada;
            model.datosVehiculo.ReciboNumero = model.ReciboNumero;
            model.datosVehiculo.Recibio = model.Recibio;
            model.datosVehiculo.Pago = model.Pago;
            model.datosVehiculo.NumeroResponsiva = model.NumeroResponsiva;
            model.datosVehiculo.LugarRevision = model.LugarRevision;
            model.datosVehiculo.UsuarioRegistro = model.UsuarioRegistro;
            model.datosVehiculo.Ficha = model.Ficha;

            _contenedorTrabajo.Vehiculo.Update(model.datosVehiculo);
            _contenedorTrabajo.Save();

            return View();
        }

        //ActionResult que manda llamar ajax para obtener el valor de las sub marcas de acuerdo a la marca
        public ActionResult GetSubMarcas(int valor)
        {
            var resultado = _contenedorTrabajo.Modelo.GetSubMarcasPorMarca(valor);
            return Json(new { Data = resultado });
        }

        public ActionResult RegistraVendedor(string nombre, string telefono)
        {
            VehiculoViewModel datos = new VehiculoViewModel();
            datos.VendedorDatos = new Modelos.Models.Vendedor();

            datos.VendedorDatos.Nombre = nombre;
            datos.VendedorDatos.NoTelefono = telefono;

            int resultado = _contenedorTrabajo.Vendedor.RegistraVendedor(datos.VendedorDatos);

            if (resultado > 0)
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Vendedor registrado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Error en el registro del vendedor";
                TempData["TipoMensaje"] = "warning";
            }


            return Json(new { Data = resultado });
        }

        public ActionResult RegistraComprador(string nombre, string telefono)
        {
            VehiculoViewModel datos = new VehiculoViewModel();
            datos.CompradorDatos = new Modelos.Models.Comprador();

            datos.CompradorDatos.Nombre = nombre;
            datos.CompradorDatos.NoTelefono = telefono;

            int resultado = _contenedorTrabajo.Comprador.RegistraComprador(datos.CompradorDatos);

            if (resultado > 0)
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Comprador registrado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Error en el registro del comprador";
                TempData["TipoMensaje"] = "warning";
            }


            return Json(new { Data = resultado });
        }

        public ActionResult RegistraFacturacionComprador(string rfc, string direccion, string colonia, string cp, int idComprador)
        {
            VehiculoViewModel datos = new VehiculoViewModel();
            datos.CompradorDatos = _contenedorTrabajo.Comprador.GetCompradorById(idComprador);

            datos.CompradorDatos.RFC = rfc;
            datos.CompradorDatos.Direccion = direccion;
            datos.CompradorDatos.Colonia = colonia;
            datos.CompradorDatos.CodigoPostal = cp;
            
            bool resultado = _contenedorTrabajo.Comprador.Update(datos.CompradorDatos);

            if (resultado)
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Datos de facturación registrados con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Error en el registro de los datos de facturación del comprador";
                TempData["TipoMensaje"] = "warning";
            }


            return Json(new { Data = resultado });
        }

        public ActionResult RegistraFacturacionVendedor(string rfc, string direccion, string colonia, string cp, int idVendedor)
        {
            VehiculoViewModel datos = new VehiculoViewModel();
            datos.VendedorDatos = _contenedorTrabajo.Vendedor.GetVendedorById(idVendedor);

            datos.VendedorDatos.RFC = rfc;
            datos.VendedorDatos.Direccion = direccion;
            datos.VendedorDatos.Colonia = colonia;
            datos.VendedorDatos.CodigoPostal = cp;

            bool resultado = _contenedorTrabajo.Vendedor.Update(datos.VendedorDatos);

            if (resultado)
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Datos de facturación registrados con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Nueva captura";
                TempData["Mensaje"] = "Error en el registro de los datos de facturación del vendedor";
                TempData["TipoMensaje"] = "warning";
            }


            return Json(new { Data = resultado });
        }

        public ActionResult GetDatosSerie(string  serie)
        {
            AIVA.Modelos.Models.Vehiculo resultado = _contenedorTrabajo.Vehiculo.GetVehiculoBySerie(serie);

            if(resultado != null)
               return Json(new { Data = resultado });
            else
                return Json(new { Data = "" });
        }

        public ActionResult GetListadoGeneralVendedores(string nvendedor)
        {
            VehiculoViewModel modelo = new VehiculoViewModel();
            modelo.ListaVendedores = new List<Modelos.Models.Vendedor>();
            modelo.ListaVendedores = _contenedorTrabajo.Vendedor.GetVendedoresByNombre(nvendedor);

            return PartialView("_ListaVendedores", modelo);
        }

        public ActionResult GetListadoGeneralCompradores(string ncomprador)
        {
            VehiculoViewModel modelo = new VehiculoViewModel();
            modelo.ListaCompradores = new List<Modelos.Models.Comprador>();
            modelo.ListaCompradores = _contenedorTrabajo.Comprador.GetCompradorByNombre(ncomprador);
                      
            return PartialView("_ListaCompradores", modelo);
        }

        public ActionResult ObtenIdVendedor(int data)
        {

            AIVA.Modelos.Models.Vendedor resultado = _contenedorTrabajo.Vendedor.GetVendedorById(data);

            if (resultado != null)
                return Json(new { Data = resultado });
            else
                return Json(new { Data = "" });
        }


        public ActionResult ObtenIdComprador(int data)
        {

            AIVA.Modelos.Models.Comprador resultado = _contenedorTrabajo.Comprador.GetCompradorById(data);

            if (resultado != null)
                return Json(new { Data = resultado });
            else
                return Json(new { Data = "" });
        }
    }
}
