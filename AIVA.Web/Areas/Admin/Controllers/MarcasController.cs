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
    public class MarcasController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public MarcasController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaMarcas = _contenedorTrabajo.Marca.GetMarcas();
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

            model.datosMarcas = new Marca();
            model.datosMarcas.Descripcion = model.Descripcion;
            bool resultado =  _contenedorTrabajo.Marca.Create(model.datosMarcas);
            _contenedorTrabajo.Save();


            if (resultado)
            {
                TempData["Titulo"] = "Marcas de autos";
                TempData["Mensaje"] = "Marca registrada con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Marcas de autos";
                TempData["Mensaje"] = "Error en el registro de la marca";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Marcas", new { });
            return Redirect(url);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CatalogosViewModel _datos = new CatalogosViewModel();

            var _info = _contenedorTrabajo.Marca.GetById(id);

            _datos.id = _info.id;
            _datos.Descripcion = _info.Descripcion;


            return View(_datos);
        }

        [HttpPost]
        public ActionResult Edit(CatalogosViewModel model)
        {
            model.datosMarcas = new Marca();
            model.datosMarcas.id = model.id;
            model.datosMarcas.Descripcion = model.Descripcion;


            bool resultado = _contenedorTrabajo.Marca.Update(model.datosMarcas);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Marcas de autos";
                TempData["Mensaje"] = "Registro actualizado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Marcas de autos";
                TempData["Mensaje"] = "Error en la actualización del registro";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Marcas", new { });
            return Redirect(url);
        }



        public IActionResult Delete(int id)
        {
            Marca obj = _contenedorTrabajo.Marca.GetById(id);

            if (obj == null)
            {
                TempData["Titulo"] = "Marcas";
                TempData["Mensaje"] = "Error en el borrado del registro indicado";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                _contenedorTrabajo.Marca.Delete(obj);
                _contenedorTrabajo.Save();

                TempData["Titulo"] = "Marcas";
                TempData["Mensaje"] = "Registro eliminado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "Marcas", new { });
            return Redirect(url);
        }

    }
}
