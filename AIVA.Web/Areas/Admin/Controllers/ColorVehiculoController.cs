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
    public class ColorVehiculoController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ColorVehiculoController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaPinturasVehiculos = _contenedorTrabajo.ColorVehiculo.GetColoresVehiculos();
            return View(_datos);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            return View(_datos);
        }


        [HttpPost]
        public ActionResult Create(CatalogosViewModel model)
        {
            model.datosColorPintura = new ColoresVehiculos();
            model.datosColorPintura.Descripcion = model.Descripcion;
            bool resultado = _contenedorTrabajo.ColorVehiculo.Create(model.datosColorPintura);

            if (resultado)
            {
                TempData["Titulo"] = "Colores de vehículos";
                TempData["Mensaje"] = "Color registrado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Colores de vehículos";
                TempData["Mensaje"] = "Error en el registro del nuevo color";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "ColorVehiculo", new { });
            return Redirect(url);

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CatalogosViewModel _datos = new CatalogosViewModel();

            var _info = _contenedorTrabajo.ColorVehiculo.GetById(id);

            _datos.id = _info.id;
            _datos.Descripcion = _info.Descripcion;
          
            return View(_datos);
        }

        [HttpPost]
        public ActionResult Edit(CatalogosViewModel model)
        {
            model.datosColorPintura = new ColoresVehiculos();
            model.datosColorPintura.id = model.id;
            model.datosColorPintura.Descripcion = model.Descripcion;
            
            bool resultado =  _contenedorTrabajo.ColorVehiculo.Update(model.datosColorPintura);

            if (resultado)
            {
                TempData["Titulo"] = "Colores de vehículos";
                TempData["Mensaje"] = "Registro actualizado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else {
                TempData["Titulo"] = "Colores de vehículos";
                TempData["Mensaje"] = "Error en la actualización del registro";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "ColorVehiculo", new { });
            return Redirect(url);
        }

       
        public IActionResult Delete(int id)
        {
            ColoresVehiculos obj = _contenedorTrabajo.ColorVehiculo.Get(id);

            if (obj == null)
            {
                TempData["Titulo"] = "Colores de vehículos";
                TempData["Mensaje"] = "Error en el borrado del color seleccionado";
                TempData["TipoMensaje"] = "warning";
            }
            else {
                _contenedorTrabajo.ColorVehiculo.Delete(obj);
                _contenedorTrabajo.Save();

                TempData["Titulo"] = "Colores de vehículos";
                TempData["Mensaje"] = "Color eliminado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "ColorVehiculo", new { });
            return Redirect(url);
        }


    }
}
