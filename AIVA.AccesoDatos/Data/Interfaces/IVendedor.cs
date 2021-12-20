using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIVA.Modelos.Models;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IVendedor : IRepository<Vendedor>
    {
        List<Vendedor> GetVendedores();

        Vendedor GetVendedorById(int id);

        bool Create(Vendedor model);

        bool Update(Vendedor cliente);

        int RegistraVendedor(Vendedor model);
    }
}
