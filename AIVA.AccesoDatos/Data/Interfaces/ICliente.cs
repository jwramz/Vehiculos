using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface ICliente : IRepository<Cliente>
    {
       List<Cliente> GetClientes();

        Cliente GetClienteById(int id);
        
        bool Create(Cliente model);

        bool Update(Cliente cliente);

        List<SelectListItem> GetListaEstados();

        List<SelectListItem> GetListaMunicipios();

        List<SelectListItem> GetMunicipiosPorEstado(int id);

        bool Delete(Cliente model);
    }
}
