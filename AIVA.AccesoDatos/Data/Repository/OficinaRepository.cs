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
    public class OficinaRepository : Repository<Oficina>, IOficina
    {

        private readonly ApplicationDbContext _db;

        public OficinaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public List<Oficina> GetOficinas()
        {
            try
            {
                var list = _db.Oficina.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Oficina>();
            }
        }

        public Oficina GetById(int id)
        {
            try
            {
                Oficina _oficina = new Oficina();
                _oficina = _db.Oficina.Where(x => x.id == id).FirstOrDefault();
                return _oficina;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Oficina();
            }
        }

        public bool Create(Oficina model)
        {
            try
            {
                _db.Oficina.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(Oficina model)
        {
            try
            {
                var datos = _db.Oficina.FirstOrDefault(s => s.id == model.id);
                datos.Descripcion = model.Descripcion;
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

        public bool Delete(Oficina model)
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


        public List<SelectListItem> GetListaOficinas()
        {
            try
            {
                var list = _db.Oficina.Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
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
