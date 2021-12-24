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
    public class CompradorRepository : Repository<Comprador>, IComprador
    {
        private readonly ApplicationDbContext _db;

        public CompradorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Comprador> GetCompradores()
        {

            try
            {
                var list = _db.Comprador.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Comprador>();
            }
        }

        public Comprador GetCompradorById(int id)
        {
            try
            {
                Comprador _comprador = new Comprador();
                _comprador = _db.Comprador.Where(x => x.id == id).FirstOrDefault();
                return _comprador;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Comprador();
            }
        }
               
        public bool Create(Comprador model)
        {
            try
            {
                _db.Comprador.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(Comprador _comprador)
        {
            try
            {
                //var datos = _db.Comprador.FirstOrDefault(s => s.id == _comprador.id);

                _comprador.Estatus = true;
                _comprador.FechaRegistro = DateTime.Now;
          
                _db.Update(_comprador);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public int RegistraComprador(Comprador model)
        {
            try
            {
                model.Estatus = true;
                model.FechaRegistro = DateTime.Now;

                _db.Comprador.Add(model);
                _db.SaveChanges();

                return model.id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }


        public List<Comprador> GetCompradorByNombre(string nombre)
        {
            try
            {
                List<Comprador> _comprador= new List<Comprador>();
                _comprador = _db.Comprador.Where(x => x.Nombre.Contains(nombre)).ToList();
                return _comprador;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Comprador>();
            }
        }

    }
}
