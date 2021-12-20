using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IModelo : IRepository<SubMarca>
    {
        List<SubMarca> GetModelos();

        SubMarca GetById(int id);

        bool Create(SubMarca model);

        bool Update(SubMarca model);

        bool Delete(SubMarca model);

        List<SelectListItem> GetSubMarcasPorMarca(int id);

    }
}
