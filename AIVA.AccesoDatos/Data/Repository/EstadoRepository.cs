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
    public  class EstadoRepository : Repository<Estados>, IEstado
    {
        private readonly ApplicationDbContext _db;

        public EstadoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Estados> GetEstados()
        {

            try
            {
                var list = _db.Estados.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Estados>();
            }
        }

        public Estados GetById(int id)
        {
            try
            {
                Estados _estados = new Estados();
                _estados = _db.Estados.Where(x => x.id == id).FirstOrDefault();
                return _estados;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Estados();
            }
        }

        public bool Create(Estados model)
        {
            try
            {
                _db.Estados.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(Estados model)
        {
            try
            {
                var datos = _db.Estados.FirstOrDefault(s => s.id == model.id);

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



        public bool Delete(Estados model)
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
