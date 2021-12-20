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
    public class VendedorController : Controller
    {

        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public VendedorController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            VendedorViewModel _vendedor = new VendedorViewModel();
            _vendedor.listaVendedores = _contenedorTrabajo.Vendedor.GetVendedores();
            return View(_vendedor);
        }

        [HttpGet]
        public ActionResult Create()
        {
            VendedorViewModel _vendedor = new VendedorViewModel();
            return View(_vendedor);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            VendedorViewModel _vendedor = new VendedorViewModel();

            var _datosVendedor = _contenedorTrabajo.Vendedor.GetVendedorById(id);

            _vendedor.id = _datosVendedor.id;
            _vendedor.Nombre = _datosVendedor.Nombre;
            _vendedor.NoTelefono = _datosVendedor.NoTelefono;
            _vendedor.Direccion = _datosVendedor.Direccion;
            _vendedor.Colonia = _datosVendedor.Colonia;
            _vendedor.CodigoPostal = _datosVendedor.CodigoPostal;

            return View(_vendedor);
        }
    }
}
