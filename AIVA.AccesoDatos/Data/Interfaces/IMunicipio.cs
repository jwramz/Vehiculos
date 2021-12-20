using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IMunicipio : IRepository<Municipio>
    {
        List<Municipio> GetMunicipios();

        Municipio GetById(int id);

        bool Create(Municipio model);

        bool Update(Municipio model);

        bool Delete(Municipio model);
    }
}
