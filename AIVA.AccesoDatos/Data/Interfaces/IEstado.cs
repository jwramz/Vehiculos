using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IEstado :  IRepository<Estados>
    {
        List<Estados> GetEstados();

        Estados GetById(int id);

        bool Create(Estados model);

        bool Update(Estados model);

        bool Delete(Estados model);
    }
}
