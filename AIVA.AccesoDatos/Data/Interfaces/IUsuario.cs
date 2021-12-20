using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIVA.Modelos.Models;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IUsuario : IRepository<ApplicationUser>
    {
        void BloqueaUsuario(string IdUsuario);
        void DesbloquearUsuario(string IdUsuario);
    }
}
