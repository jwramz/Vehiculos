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
    public class MarcaRepository : Repository<Marca>, IMarca
    {
        private readonly ApplicationDbContext _db;

        public MarcaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public List<Marca> GetMarcas()
        {
            try
            {
                var list = _db.Marca.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Marca>();
            }
        }

        public Marca GetById(int id)
        {
            try
            {
                Marca _marca = new Marca();
                _marca = _db.Marca.Where(x => x.id == id).FirstOrDefault();
                return _marca;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Marca();
            }
        }

        public bool Create(Marca model)
        {
            try
            {
                _db.Marca.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(Marca model)
        {
            try
            {
                var datos = _db.Marca.FirstOrDefault(s => s.id == model.id);

                datos.Estatus = true;
                datos.FechaRegistro = DateTime.Now;
                datos.Descripcion = model.Descripcion;

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


        public bool Delete(Marca model)
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
