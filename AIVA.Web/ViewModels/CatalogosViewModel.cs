using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AIVA.Web.ViewModels
{
    public class CatalogosViewModel
    {
        public int id { get; set; }
    
        public int idMunicipio { get; set; }

        public int idModeloAuto { get; set; }

        public int idMarcaAuto { get; set; }

        public int idEstadoRegistrado { get; set; }

        public string Descripcion { get; set; }

        public Municipio datosMunicipios { get; set; }
  
        public Estados datosEstados { get; set; }
   
        public Oficina datosOficina { get; set; }
   
        public SubMarca  datosModelos { get; set; }
     
        public Marca datosMarcas { get; set; }

        public ColoresVehiculos datosColorPintura { get; set; }
     
        public AnioModelo datosAmodeloVehiculo { get; set; }

        public List<Municipio> listaMunicipios { get; set; }
      
        public List<Estados> listaEstados { get; set; }

        public List<Oficina> listaOficinas { get; set; }
     
        public List<SubMarca> listaModelosVehiculo { get; set; }

        public List<Marca> listaMarcas { get; set; }
      
        public List<ColoresVehiculos> listaPinturasVehiculos { get; set; }
        
        public List<AnioModelo> listaAModeloVehiculos { get; set; }


        public List<SelectListItem> listaEstadosDDL { get; set; }
        public List<SelectListItem> listaMarcasDDL { get; set; }



    }
}
