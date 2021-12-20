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
    public class CompradorController : Controller
    {

        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public CompradorController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CompradorViewModel _comprador = new CompradorViewModel();
            _comprador.listaCompradores = _contenedorTrabajo.Comprador.GetCompradores();
            return View(_comprador);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CompradorViewModel _comprador = new CompradorViewModel();
            return View(_comprador);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CompradorViewModel _comprador = new CompradorViewModel();

            var _datosComprador = _contenedorTrabajo.Comprador.GetCompradorById(id);

            _comprador.id = _datosComprador.id;
            _comprador.Nombre = _datosComprador.Nombre;
            _comprador.NoTelefono = _datosComprador.NoTelefono;
            _comprador.Direccion = _datosComprador.Direccion;
            _comprador.Colonia = _datosComprador.Colonia;
            _comprador.CodigoPostal = _datosComprador.CodigoPostal;

            return View(_comprador);
        }
    }
}
