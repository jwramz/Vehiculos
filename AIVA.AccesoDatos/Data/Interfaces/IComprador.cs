using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIVA.Modelos.Models;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IComprador : IRepository<Comprador>
    {
        List<Comprador> GetCompradores();

        Comprador GetCompradorById(int id);

        bool Create(Comprador model);

        bool Update(Comprador cliente);

        int RegistraComprador(Comprador model);

        List<Comprador> GetCompradorByNombre(string nombre);

    }
}
