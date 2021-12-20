using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AIVA.Web.ViewModels
{
    public class VendedorViewModel
    {
        //Datos del vendedor 
        public int id { get; set; }

        [DisplayName("Nombre")]
        public string Nombre { get; set; }

        [DisplayName("Teléfono")]
        public string NoTelefono { get; set; }
        
        [DisplayName("Teléfono móvil")]
        public string NoCelular { get; set; }

        [DisplayName("Tipo de identificación")]
        public int tipoidentificacion { get; set; }

        [DisplayName("Número de identificación")]
        public string ValorIdentificacion { get; set; }

        [DisplayName("Domicilio")]
        public string Direccion { get; set; }

        [DisplayName("Colonia")]
        public string Colonia { get; set; }

        [DisplayName("Municipio")]
        public string Municipio { get; set; }

        [DisplayName("Código postal")]
        public string CodigoPostal { get; set; }

        [DisplayName("Estado")]
        public string Estado { get; set; }

        [DisplayName("País")]
        public string Pais { get; set; }



        //Información de registro del dato
        [DisplayName("Fecha de registro")]
        public DateTime FechaRegistro { get; set; }

        [DisplayName("Estatus")]
        public string Estatus { get; set; }



        //Datos facturación
        [DisplayName("RFC")]
        public string RFC { get; set; }


        public List<Vendedor> listaVendedores { get; set; }

        public Vendedor datosVendedor { get; set; } 

    }
}
