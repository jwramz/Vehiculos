using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.Modelos.Models
{

    [Table("ReporteVehiculo")]
    public class ReporteVehiculo
    {

        [Key]
        public int id { get; set; }

        public string Marca { get; set; }

        public string SubMarca { get; set; }
             
        public string Modelo { get; set; }

        public int? AnioModelo { get; set; }
               
        public string Color { get; set; }
              
        public string NoSerie { get; set; }

        public string NoPlaca { get; set; }

        public string NoMotor { get; set; }

        public string Estado { get; set; }

        public string Pais { get; set; }

        public string Observaciones { get; set; }
              
        public string CincoDigitos { get; set; }

        public string Averiguacion { get; set; }

        public string Base { get; set; }

        public string ModusOperandi { get; set; }

        public string Lugar { get; set; }

        public string RFV { get; set; }

        public string Violencia { get; set; }
    }
}
