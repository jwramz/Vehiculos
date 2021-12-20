using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IMarca
    {
        List<Marca> GetMarcas();

        Marca GetById(int id);

        bool Create(Marca model);

        bool Update(Marca model);

        bool Delete(Marca model);
    }
}
