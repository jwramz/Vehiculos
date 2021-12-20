using AIVA.AccesoDatos.Data.Interfaces;
using AIVA.Modelos.Models;
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
    public class ClienteController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;


        public ClienteController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ClienteViewModel clientes = new ClienteViewModel();
            clientes.listaClientes = _contenedorTrabajo.Cliente.GetClientes();
            return View(clientes);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ClienteViewModel clientes = new ClienteViewModel();

            clientes.listaEstados = _contenedorTrabajo.Cliente.GetListaEstados();
            clientes.listaMunicipios = _contenedorTrabajo.Cliente.GetListaMunicipios();

            return View(clientes);
        }

        [HttpPost]
        public ActionResult Create(ClienteViewModel model)
        {
            model.datosCliente = new Modelos.Models.Cliente();
            model.datosCliente.Nombre = model.Nombre;
            model.datosCliente.Telefono = model.Telefono;
            model.datosCliente.NoCelular = "";
            model.datosCliente.RazonSocial = model.RazonSocial;
            model.datosCliente.RFC = model.RFC;
            model.datosCliente.Domicilio = model.Domicilio;
            model.datosCliente.Colonia = model.Colonia;
            model.datosCliente.idMunicipio = model.idMunicipio;
            model.datosCliente.Estado = model.Estado;
            model.datosCliente.CodigoPostal = model.CodigoPostal;

            model.datosCliente.HorarioPorDefecto = model.CodigoPostal;
            model.datosCliente.ISR = model.ISR;
            model.datosCliente.IVA = model.IVA;
            model.datosCliente.idEstado = model.idEstado;

            bool resultado = _contenedorTrabajo.Cliente.Create(model.datosCliente);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Clientes";
                TempData["Mensaje"] = "Cliente registrado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Clientes de autos";
                TempData["Mensaje"] = "Error en el registro del cliente";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Cliente", new { });
            return Redirect(url);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ClienteViewModel clientes = new ClienteViewModel();

            var _cliente = _contenedorTrabajo.Cliente.GetClienteById(id);

        
            clientes.listaEstados = _contenedorTrabajo.Cliente.GetListaEstados();
            clientes.listaMunicipios = _contenedorTrabajo.Cliente.GetListaMunicipios();

            clientes.id = _cliente.id;
            clientes.Nombre = _cliente.Nombre;
            clientes.Telefono = _cliente.Telefono;
            clientes.RazonSocial = _cliente.RazonSocial;
            clientes.Domicilio = _cliente.Domicilio;
            clientes.Colonia = _cliente.Colonia;
            
            clientes.Horario = _cliente.HorarioPorDefecto;
            clientes.RFC = _cliente.RFC;
            clientes.ISR = _cliente.ISR;
            clientes.IVA = _cliente.IVA;

            if(_cliente.idEstado.HasValue)
              clientes.idEstado = (int) _cliente.idEstado;

            if(_cliente.idMunicipio.HasValue)
               clientes.idMunicipio = (int)_cliente.idMunicipio;

            clientes.Estado = _cliente.Estado;
            clientes.CodigoPostal = _cliente.CodigoPostal;
            
            return View(clientes);
        }

        [HttpPost]
        public ActionResult Edit(ClienteViewModel model)
        {
            model.datosCliente = new Modelos.Models.Cliente();
            model.datosCliente.id = model.id;
            model.datosCliente.Nombre = model.Nombre;
            model.datosCliente.Telefono = model.Telefono;
            model.datosCliente.NoCelular = "";
            model.datosCliente.RazonSocial = model.RazonSocial;
            model.datosCliente.RFC = model.RFC;
            model.datosCliente.Domicilio = model.Domicilio;
            model.datosCliente.Colonia = model.Colonia;
            model.datosCliente.idMunicipio = model.idMunicipio;
            model.datosCliente.Estado = model.Estado;
            model.datosCliente.CodigoPostal = model.CodigoPostal;

            model.datosCliente.IVA = model.IVA;
            model.datosCliente.ISR = model.ISR;
            model.datosCliente.HorarioPorDefecto = model.Horario;
            model.datosCliente.idEstado = model.idEstado;

            bool resultado = _contenedorTrabajo.Cliente.Update(model.datosCliente);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Clientes";
                TempData["Mensaje"] = "Datos del cliente actualizados con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Clientes de autos";
                TempData["Mensaje"] = "Error en la actualización de los datos del cliente";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Cliente", new { });
            return Redirect(url);
        }

        //ActionResult que manda llamar ajax para obtener el valor de los municipios por estado
        public ActionResult GetMunicipios(int valor)
        {
            var resultado = _contenedorTrabajo.Cliente.GetMunicipiosPorEstado(valor);
            return Json(new { Data = resultado});
        }

        public IActionResult Delete(int id)
        {
            Modelos.Models.Cliente obj = _contenedorTrabajo.Cliente.GetClienteById(id);

            if (obj == null)
            {
                TempData["Titulo"] = "Cliente";
                TempData["Mensaje"] = "Error en el borrado del registro del cliente seleccionado";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                _contenedorTrabajo.Cliente.Delete(obj);
                _contenedorTrabajo.Save();

                TempData["Titulo"] = "Cliente";
                TempData["Mensaje"] = "Registro eliminado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "Cliente", new { });
            return Redirect(url);
        }


    }
}
