using AIVA.AccesoDatos.Data.Interfaces;
using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Repository
{
    public class UsuarioRepository : Repository<ApplicationUser>, IUsuario
    {
        private readonly ApplicationDbContext _db;

        public UsuarioRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void BloqueaUsuario(string IdUsuario)
        {
            throw new NotImplementedException();
        }

        public void DesbloquearUsuario(string IdUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
