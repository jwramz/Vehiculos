using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.Modelos.Models
{
    public class Oficina
    {
        [Key]
        public int id { get; set; }

        public string Descripcion { get; set; }

        public DateTime? FechaRegistro { get; set; }

        public bool? Estatus { get; set; }
    }
}
