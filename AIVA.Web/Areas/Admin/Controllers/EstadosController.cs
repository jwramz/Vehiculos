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
    public class EstadosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public EstadosController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

       
        [HttpGet]
        public IActionResult Index()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaEstados = _contenedorTrabajo.Estado.GetEstados();
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
            model.datosEstados = new Estados();
            model.datosEstados.Descripcion = model.Descripcion;
            bool resultado = _contenedorTrabajo.Estado.Create(model.datosEstados);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Estados";
                TempData["Mensaje"] = "Estado registrado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Estados";
                TempData["Mensaje"] = "Error en el registro del estado";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Estados", new { });
            return Redirect(url);

         
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CatalogosViewModel _datos = new CatalogosViewModel();

            var _info = _contenedorTrabajo.Estado.GetById(id);

            _datos.id = _info.id;
            _datos.Descripcion = _info.Descripcion;


            return View(_datos);
        }

        [HttpPost]
        public ActionResult Edit(CatalogosViewModel model)
        {
            model.datosEstados = new Estados();
            model.datosEstados.id = model.id;
            model.datosEstados.Descripcion = model.Descripcion;

            bool resultado = _contenedorTrabajo.Estado.Update(model.datosEstados);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Estados";
                TempData["Mensaje"] = "Registro actualizado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Estados";
                TempData["Mensaje"] = "Error en la actualización del registro";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Estados", new { });
            return Redirect(url);
        }


        public IActionResult Delete(int id)
        {
            Estados obj = _contenedorTrabajo.Estado.Get(id);

            if (obj == null)
            {
                TempData["Titulo"] = "Estados";
                TempData["Mensaje"] = "Error en el borrado del registro indicado";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                _contenedorTrabajo.Estado.Delete(obj);
                _contenedorTrabajo.Save();

                TempData["Titulo"] = "Estados";
                TempData["Mensaje"] = "Registro eliminado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "Estados", new { });
            return Redirect(url);
        }

    }
}
