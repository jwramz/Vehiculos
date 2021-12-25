using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.Modelos.Models
{
    [Table("Vehiculo")]
    public class Vehiculo
    {
        [Key]
        public int id { get; set; }

        public string Marca { get; set; }

        public int? idMarca { get; set; }
  
        [ForeignKey("idMarca")]
        public virtual Marca MarcaVehiculo { get; set; }

        public string SubMarca { get; set; }

        public int? idSubMarca { get; set; }
    
        [ForeignKey("idSubMarca")]
        public virtual SubMarca SubMarcaVehiculo { get; set; }

        public string Modelo { get; set; }

        public int? idModelo { get; set; }
      
        [ForeignKey("idModelo")]
        public virtual AnioModelo AnioModeloVehiculo { get; set; }

        public string Color { get; set; }

        public int? idColor { get; set; }
      
        [ForeignKey("idColor")]
        public virtual ColoresVehiculos ColoresVehiculo { get; set; }

        public string NoSerie { get; set; }

        public string NoPlaca { get; set; }

        public string NoMotor { get; set; }

        public int? TipoVehiculo { get; set; }

        public string Estado { get; set; }

        public int? idEstado { get; set; }
    
        [ForeignKey("idEstado")]
        public virtual Estados EstadoOrigen { get; set; }

        public int? idPais { get; set; }

        public int? idComprador { get; set; }
        [ForeignKey("idComprador")]
        public virtual Comprador Comprador { get; set; }

        public int? idVendedor { get; set; }
       
        [ForeignKey("idVendedor")]
        public virtual Vendedor Vendedor { get; set; }

        public string Observaciones { get; set; }

        public int? TipoReporte { get; set; }

        public int? DocumentosAprocrifos { get; set; }

        public int? NumeracionAlterada { get; set; }

        public int? ReciboNumero { get; set; }

        public string Recibio { get; set; }

        public int? Pago { get; set; }

        public int? NumeroResponsiva { get; set; }

        public int? LugarRevision { get; set; }

        [ForeignKey("LugarRevision")]
        public virtual Oficina Oficina { get; set; }

        public string UsuarioRegistro { get; set; } 

        public int? Ficha { get; set; }

        public int? NoRegistro { get; set; }

        public int? CheckDebe { get; set; }

        public DateTime? FechaRegistro { get; set; }
        
        public bool? Estatus { get; set; }

        public int? procedencia { get; set; }

        public int? CincoDigitos { get; set; }


    }
}
