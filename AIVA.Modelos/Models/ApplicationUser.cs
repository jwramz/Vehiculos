using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.Modelos.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        [Required(ErrorMessage = "La ciudad es obligatorio")]
        public string Ciudad { get; set; }
        [Required(ErrorMessage = "EL país es obligatorio")]
        public string Pais { get; set; }
    }
}
