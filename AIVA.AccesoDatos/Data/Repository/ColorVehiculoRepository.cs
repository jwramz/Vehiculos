using AIVA.AccesoDatos.Data.Interfaces;
using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AIVA.AccesoDatos.Data.Repository
{
    public class ColorVehiculoRepository : Repository<ColoresVehiculos>, IColorVehiculo
    {
        private readonly ApplicationDbContext _db;

        public ColorVehiculoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<ColoresVehiculos> GetColoresVehiculos()
        {

            try
            {
                var list = _db.PinturaVehiculo.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<ColoresVehiculos>();
            }
        }

        public ColoresVehiculos GetById(int id)
        {
            try
            {
                ColoresVehiculos _datos = new ColoresVehiculos();
                _datos = _db.PinturaVehiculo.Where(x => x.id == id).FirstOrDefault();
                return _datos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new ColoresVehiculos();
            }
        }

        public bool Create(ColoresVehiculos model)
        {
            try
            {
                _db.PinturaVehiculo.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(ColoresVehiculos model)
        {
            try
            {
              
                var datos = _db.PinturaVehiculo.FirstOrDefault(s => s.id == model.id);
                datos.Descripcion = model.Descripcion;
                datos.Estatus = true;
                datos.FechaRegistro = DateTime.Now;
                _db.SaveChanges();  
              

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }





        public bool Delete(ColoresVehiculos model)
        {
            try
            {
                
                _db.Remove(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }


    }
}
