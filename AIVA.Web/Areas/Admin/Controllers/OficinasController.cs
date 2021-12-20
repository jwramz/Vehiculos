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
    public class OficinasController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public OficinasController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaOficinas = _contenedorTrabajo.Oficina.GetOficinas();
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
            model.datosOficina = new Oficina();
            model.datosOficina.Descripcion = model.Descripcion;
            bool resultado = _contenedorTrabajo.Oficina.Create(model.datosOficina);
          
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Oficinas";
                TempData["Mensaje"] = "Oficina registrada con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Oficinas";
                TempData["Mensaje"] = "Error al registrar los datos de la oficina";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Oficinas", new { });
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
            model.datosOficina = new Oficina();
            model.datosOficina.id = model.id;
            model.datosOficina.Descripcion = model.Descripcion;
            bool resultado =  _contenedorTrabajo.Oficina.Update(model.datosOficina);

            if (resultado)
            {
                TempData["Titulo"] = "Oficinas";
                TempData["Mensaje"] = "Registro actualizado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Oficinas";
                TempData["Mensaje"] = "Error en la actualización del registro";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Oficinas", new { });
            return Redirect(url);
        }

        public IActionResult Delete(int id)
        {
            Oficina obj = _contenedorTrabajo.Oficina.Get(id);

            if (obj == null)
            {
                TempData["Titulo"] = "Oficinas";
                TempData["Mensaje"] = "Error en el borrado del registro indicado";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                _contenedorTrabajo.Oficina.Delete(obj);
                _contenedorTrabajo.Save();

                TempData["Titulo"] = "Oficinas";
                TempData["Mensaje"] = "Registro eliminado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "Oficinas", new { });
            return Redirect(url);
        }

    }
}
