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
    public class AModeloController : Controller
    {

        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public AModeloController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaAModeloVehiculos = _contenedorTrabajo.AModelo.GetAniosModelo();
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
            model.datosAmodeloVehiculo = new AnioModelo();
            model.datosAmodeloVehiculo.Descripcion = model.Descripcion;
            bool resultado = _contenedorTrabajo.AModelo.Create(model.datosAmodeloVehiculo);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Año del modelo de auto";
                TempData["Mensaje"] = "Año registrado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Año del modelo de auto";
                TempData["Mensaje"] = "Error en el registro del año";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "AModelo", new { });
            return Redirect(url);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CatalogosViewModel _datos = new CatalogosViewModel();

            var _info = _contenedorTrabajo.AModelo.GetById(id);

            _datos.id = _info.id;
            _datos.Descripcion = _info.Descripcion;


            return View(_datos);
        }

        [HttpPost]
        public ActionResult Edit(CatalogosViewModel model)
        {

            model.datosAmodeloVehiculo = new AnioModelo();
            model.datosAmodeloVehiculo.id = model.id;
            model.datosAmodeloVehiculo.Descripcion = model.Descripcion;
            bool resultado = _contenedorTrabajo.AModelo.Update(model.datosAmodeloVehiculo);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Año del modelo de auto";
                TempData["Mensaje"] = "Registro actualizado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Año del modelo de auto";
                TempData["Mensaje"] = "Error en la actualización del registro";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "AModelo", new { });
            return Redirect(url);
        }


        public IActionResult Delete(int id)
        {
            AnioModelo obj = _contenedorTrabajo.AModelo.Get(id);

            if (obj == null)
            {
                TempData["Titulo"] = "Año del modelo de auto";
                TempData["Mensaje"] = "Error en el borrado del registro indicado";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                _contenedorTrabajo.AModelo.Delete(obj);
                _contenedorTrabajo.Save();

                TempData["Titulo"] = "Año del modelo de auto";
                TempData["Mensaje"] = "Registro eliminado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "AModelo", new { });
            return Redirect(url);
        }
    }
}
