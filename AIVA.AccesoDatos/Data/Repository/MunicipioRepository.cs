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
    public class MunicipioRepository : Repository<Municipio>, IMunicipio
    {
        private readonly ApplicationDbContext _db;

        public MunicipioRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Municipio> GetMunicipios()
        {
            try
            {
                var list = _db.Municipios.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Municipio>();
            }
        }

        public Municipio GetById(int id)
        {
            try
            {
                Municipio _datos = new Municipio();
                _datos = _db.Municipios.Where(x => x.id == id).FirstOrDefault();
                return _datos;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Municipio();
            }
        }

        public bool Create(Municipio model)
        {
            try
            {
                _db.Municipios.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(Municipio model)
        {
            try
            {
                var datos = _db.Municipios.FirstOrDefault(s => s.id == model.id);

                datos.Estatus = true;
                datos.FechaRegistro = DateTime.Now;
                datos.Descripcion = model.Descripcion;
                datos.idEstado = model.idEstado;
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

        public bool Delete(Municipio model)
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
