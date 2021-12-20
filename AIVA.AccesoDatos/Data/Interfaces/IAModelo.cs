using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IAModelo : IRepository<AnioModelo>
    {
        List<AnioModelo> GetAniosModelo();

        AnioModelo GetById(int id);

        bool Create(AnioModelo model);

        bool Update(AnioModelo model);

        bool Delete(AnioModelo model);
    }
}
