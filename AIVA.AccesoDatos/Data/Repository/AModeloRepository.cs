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
    public class AModeloRepository : Repository<AnioModelo>, IAModelo
    {
        private readonly ApplicationDbContext _db;

        public AModeloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<AnioModelo> GetAniosModelo()
        {
            try
            {
                var list = _db.AModelo.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<AnioModelo>();
            }
        }

        public AnioModelo GetById(int id)
        {
            try
            {
                AnioModelo _AnioModelo = new AnioModelo();
                _AnioModelo = _db.AModelo.Where(x => x.id == id).FirstOrDefault();
                return _AnioModelo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new AnioModelo();
            }
        }

        public bool Create(AnioModelo model)
        {
            try
            {
                _db.AModelo.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(AnioModelo model)
        {
            try
            {
                var datos = _db.AModelo.FirstOrDefault(s => s.id == model.id);
                datos.Descripcion = model.Descripcion;
                datos.Estatus = true;
                datos.FechaRegistro = DateTime.Now;

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


        public bool Delete(AnioModelo model)
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
