using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IReporteVehiculo  : IRepository<ReporteVehiculo>
    {
        List<ReporteVehiculo> GetReporteVehiculos();

        ReporteVehiculo GetReporteVehiculoById(int id);

    }
}
