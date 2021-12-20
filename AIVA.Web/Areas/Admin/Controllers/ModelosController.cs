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
    public class ModelosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public ModelosController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaModelosVehiculo = _contenedorTrabajo.Modelo.GetModelos();
            return View(_datos);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaMarcasDDL = _contenedorTrabajo.Vehiculo.GetListaMarcas();
            return View(_datos);
        }


        [HttpPost]
        public ActionResult Create(CatalogosViewModel model)
        {
            model.datosModelos = new SubMarca();
            model.datosModelos.Descripcion = model.Descripcion;
            model.datosModelos.idMarcaVehiculo = model.idMarcaAuto;
            bool resultado =  _contenedorTrabajo.Modelo.Create(model.datosModelos);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Modelos de autos";
                TempData["Mensaje"] = "Registro actualizado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Modelos de autos";
                TempData["Mensaje"] = "Error en el registro del modelo de auto" ;
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Modelos", new { });
            return Redirect(url);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaMarcasDDL = _contenedorTrabajo.Vehiculo.GetListaMarcas();

            var _info = _contenedorTrabajo.Modelo.GetById(id);

            _datos.id = _info.id;
            _datos.Descripcion = _info.Descripcion;
            _datos.idMarcaAuto =  (int)_info.idMarcaVehiculo;


            return View(_datos);
        }

        [HttpPost]
        public ActionResult Edit(CatalogosViewModel model)
        {
            model.datosModelos.id = model.id;
            model.datosModelos.Descripcion = model.Descripcion;
            model.datosModelos.idMarcaVehiculo = model.idMarcaAuto;

            bool resultado = _contenedorTrabajo.Modelo.Update(model.datosModelos);
            _contenedorTrabajo.Save();

            if (resultado)
            {
                TempData["Titulo"] = "Modelos de autos";
                TempData["Mensaje"] = "Registro actualizado con éxito";
                TempData["TipoMensaje"] = "success";
            }
            else
            {
                TempData["Titulo"] = "Modelos de autos";
                TempData["Mensaje"] = "Error en la actualización del registro";
                TempData["TipoMensaje"] = "warning";
            }

            var url = Url.Action("Index", "Modelos", new { });
            return Redirect(url);
        }



        public IActionResult Delete(int id)
        {
            SubMarca obj = _contenedorTrabajo.Modelo.Get(id);
          
            if (obj == null)
            {
                TempData["Titulo"] = "Modelo de auto";
                TempData["Mensaje"] = "Error en el borrado del registro indicado";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                _contenedorTrabajo.Modelo.Delete(obj);
                _contenedorTrabajo.Save();

                TempData["Titulo"] = "Modelo del auto";
                TempData["Mensaje"] = "Registro eliminado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "Modelos", new { });
            return Redirect(url);
        }

    }
}
