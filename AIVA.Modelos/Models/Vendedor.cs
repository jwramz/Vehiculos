using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.Modelos.Models
{
    [Table("Vendedor")]
    public class Vendedor
    {
        [Key]
        public int id { get; set; }
        public string Nombre { get; set; }
        public string NoTelefono { get; set; }
        public string NoCelular { get; set; }
        public int? TipoIdentificacion { get; set; }
        public string ValorIdentificacion { get; set; }
        public string RFC { get; set; }
        public string Direccion { get; set; }
        public string Colonia { get; set; }

        public string CodigoPostal { get; set; }

        public DateTime? FechaRegistro { get; set; }
        public bool? Estatus { get; set; }
    }
}
