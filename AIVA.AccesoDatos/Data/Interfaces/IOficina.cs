using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IOficina : IRepository<Oficina>
    {
        List<Oficina> GetOficinas();

        Oficina GetById(int id);

        bool Create(Oficina model);

        bool Update(Oficina model);

        bool Delete(Oficina model);

        List<SelectListItem> GetListaOficinas();

    }
}
