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
    public class ModeloRepository : Repository<SubMarca>, IModelo
    {
        private readonly ApplicationDbContext _db;

        public ModeloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public List<SubMarca> GetModelos()
        {

            try
            {
                var list = _db.Modelo.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SubMarca>();
            }
        }

        public SubMarca GetById(int id)
        {
            try
            {
                SubMarca _datos = new SubMarca();
                _datos = _db.Modelo.Where(x => x.id == id).FirstOrDefault();
                return _datos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new SubMarca();
            }
        }

        public bool Create(SubMarca model)
        {
            try
            {
                _db.Modelo.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(SubMarca model)
        {
            try
            {
                var datos = _db.Modelo.FirstOrDefault(s => s.id == model.id);

                datos.Estatus = true;
                datos.FechaRegistro = DateTime.Now;
                datos.Descripcion = model.Descripcion;
                datos.idMarcaVehiculo = model.idMarcaVehiculo;
                _db.Update(datos);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        public bool Delete(SubMarca model)
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


        public List<SelectListItem> GetSubMarcasPorMarca(int id)
        {
            try
            {
                var list = _db.Modelo.Where(x => x.idMarcaVehiculo == id).Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SelectListItem>();
            }
        }



    }
}
