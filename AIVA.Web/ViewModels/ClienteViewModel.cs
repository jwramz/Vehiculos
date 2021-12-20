using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AIVA.Web.ViewModels
{
    public class ClienteViewModel
    {
        //Datos del cliente 
        public int id { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Teléfono")]
        public string Telefono { get; set; }

        [DisplayName("Domicilio")]
        public string Domicilio { get; set; }

        [DisplayName("Colonia")]
        public string Colonia { get; set; }

        [DisplayName("Municipio")]
        public string Municipio { get; set; }

        [DisplayName("Código postal")]
        public string CodigoPostal { get; set; }

        [DisplayName("Estado")]
        public string Estado { get; set; }

        public int idEstado { get; set; }

        public int idMunicipio { get; set; }

        [DisplayName("País")]
        public string Pais { get; set; }



        //Información de registro del dato
        [DisplayName("Fecha de registro")]
        public DateTime FechaRegistro { get; set; }

        [DisplayName("Estatus")]
        public string Estatus { get; set; }



        //Datos facturación
        [DisplayName("Razón social")]
        public string RazonSocial { get; set; }

        [DisplayName("% de ISR")]
        public string ISR { get; set; }

        [DisplayName("% de IVA")]
        public string IVA { get; set; }

        [DisplayName("RFC")]
        public string RFC { get; set; }

        [DisplayName("Horario por defecto")]
        public string Horario { get; set; }

        public List<Cliente> listaClientes { get; set; }

        public Cliente datosCliente { get; set; }

        public List<SelectListItem> listaMunicipios { get; set; }
        public List<SelectListItem> listaEstados { get; set; }
    }

    
}
