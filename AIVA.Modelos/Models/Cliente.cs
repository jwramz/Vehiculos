using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.Modelos.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string NoCelular { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public string Domicilio { get; set; }
        public string Colonia { get; set; }
       
        public string Estado { get; set; }

        public int? idEstado { get; set; }

        public string CodigoPostal { get; set; }

        public int? idMunicipio { get; set; }
 
        public virtual Municipio Municipio { get; set; }

        public string HorarioPorDefecto { get; set; } 
       
        public string ISR { get; set; }

        public string IVA { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? Estatus { get; set; }

    }
}
