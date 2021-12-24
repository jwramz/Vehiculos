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
    public class VendedorRepository : Repository<Vendedor>, IVendedor
    {
        private readonly ApplicationDbContext _db;

        public VendedorRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Vendedor> GetVendedores()
        {

            try
            {
                var list = _db.Vendedor.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Vendedor>();
            }
        }

        public Vendedor GetVendedorById(int id)
        {
            try
            {
                Vendedor _vendedor = new Vendedor();
                _vendedor = _db.Vendedor.Where(x => x.id == id).FirstOrDefault();
                return _vendedor;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Vendedor();
            }
        }

        public List<Vendedor> GetVendedoresByNombre(string nombre)
        {
            try
            {
                List<Vendedor> _vendedor = new List<Vendedor>();
                _vendedor = _db.Vendedor.Where(x =>  x.Nombre.Contains(nombre)).ToList();
                return _vendedor;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Vendedor>();
            }
        }


        public bool Create(Vendedor model)
        {
            try
            {
                model.Estatus = true;
                model.FechaRegistro = DateTime.Now;

                _db.Vendedor.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        public int RegistraVendedor(Vendedor model)
        {
            try
            {
                model.Estatus = true;
                model.FechaRegistro = DateTime.Now;

                _db.Vendedor.Add(model);
                _db.SaveChanges();

                return model.id;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }

        public bool Update(Vendedor _vendedor)
        {
            try
            {
                //var datos = _db.Vendedor.FirstOrDefault(s => s.id == _vendedor.id);

                _vendedor.Estatus = true;
                _vendedor.FechaRegistro = DateTime.Now;

                _db.Update(_vendedor);
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
