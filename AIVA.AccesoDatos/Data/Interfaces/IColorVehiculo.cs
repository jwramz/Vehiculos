using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IColorVehiculo : IRepository<ColoresVehiculos>
    {
        List<ColoresVehiculos> GetColoresVehiculos();

        ColoresVehiculos GetById(int id);

        bool Create(ColoresVehiculos model);

        bool Update(ColoresVehiculos model);

        bool Delete(ColoresVehiculos model);
    }
}
