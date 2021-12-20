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
    public class MunicipiosController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public MunicipiosController(IContenedorTrabajo contenedorTrabajo, IWebHostEnvironment hostingEnvironmen)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _hostingEnvironment = hostingEnvironmen;
        }

        [HttpGet]
        public IActionResult Index()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaMunicipios = _contenedorTrabajo.Municipio.GetMunicipios();
            return View(_datos);
        }

        [HttpGet]
        public ActionResult Create()
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaEstadosDDL = _contenedorTrabajo.Vehiculo.GetListaEstados();
            return View(_datos);
        }


        [HttpPost]
        public ActionResult Create(CatalogosViewModel model)
        {
            model.datosMunicipios = new Municipio();
            model.datosMunicipios.Descripcion = model.Descripcion;
            model.datosMunicipios.idEstado = model.idEstadoRegistrado;
            bool resultado = _contenedorTrabajo.Municipio.Create(model.datosMunicipios);
            _contenedorTrabajo.Save();

            if (!resultado)
            {
                TempData["Titulo"] = "Municipios";
                TempData["Mensaje"] = "Error en el registro del municipio";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                TempData["Titulo"] = "Municipios";
                TempData["Mensaje"] = "Municipio registrado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "Municipios", new { });
            return Redirect(url);

         
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            CatalogosViewModel _datos = new CatalogosViewModel();
            _datos.listaEstadosDDL = _contenedorTrabajo.Vehiculo.GetListaEstados();

            var _info = _contenedorTrabajo.Municipio.GetById(id);

            _datos.id = _info.id;
            _datos.Descripcion = _info.Descripcion;
            _datos.idEstadoRegistrado = (int) _info.idEstado;

            return View(_datos);
        }

        [HttpPost]
        public ActionResult Edit(CatalogosViewModel model)
        {

            model.datosMunicipios = new Municipio();
            model.datosMunicipios.id = model.id;
            model.datosMunicipios.Descripcion = model.Descripcion;
            model.datosMunicipios.idEstado = model.idEstadoRegistrado;

            bool resultado =  _contenedorTrabajo.Municipio.Update(model.datosMunicipios);
            _contenedorTrabajo.Save();

            if (!resultado)
            {
                TempData["Titulo"] = "Municipios";
                TempData["Mensaje"] = "Error en la actualización del registro indicado";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                TempData["Titulo"] = "Municipios";
                TempData["Mensaje"] = "Registro actualizado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "Municipios", new { });
            return Redirect(url);

         
        }



        public IActionResult Delete(int id)
        {
            Municipio obj = _contenedorTrabajo.Municipio.Get(id);

            if (obj == null)
            {
                TempData["Titulo"] = "Municipios";
                TempData["Mensaje"] = "Error en el borrado del registro indicado";
                TempData["TipoMensaje"] = "warning";
            }
            else
            {
                _contenedorTrabajo.Municipio.Delete(obj);
                _contenedorTrabajo.Save();

                TempData["Titulo"] = "Municipios";
                TempData["Mensaje"] = "Registro eliminado con éxito";
                TempData["TipoMensaje"] = "success";

            }
            var url = Url.Action("Index", "Municipios", new { });
            return Redirect(url);
        }

    }
}
