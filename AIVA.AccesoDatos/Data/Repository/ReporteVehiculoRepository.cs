using AIVA.AccesoDatos.Data.Interfaces;
using AIVA.Modelos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Repository
{
    public class ReporteVehiculoRepository : Repository<ReporteVehiculo>, IReporteVehiculo
    {
        private ApplicationDbContext _db;

        public ReporteVehiculoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public ReporteVehiculo GetReporteVehiculoById(int id)
        {
            try
            {
                ReporteVehiculo _Reportevehiculo = new ReporteVehiculo();
                _Reportevehiculo = _db.ReporteVehiculo.Where(x => x.id == id).FirstOrDefault();
                return _Reportevehiculo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new ReporteVehiculo();
            }
        }

        public List<ReporteVehiculo> GetReporteVehiculos()
        {
            try
            {
                var list = _db.ReporteVehiculo.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<ReporteVehiculo>();
            }
        }
    }
}
