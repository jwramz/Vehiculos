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
    public class ClienteRepository : Repository<Cliente>, ICliente
    {
        private readonly ApplicationDbContext _db;

        public ClienteRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Cliente> GetClientes() {

            try
            {
                var list = _db.Cliente.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Cliente>();
            }
        }

        public Cliente GetClienteById(int id)
        {
            try
            {
                Cliente _cliente = new Cliente();
                _cliente = _db.Cliente.Where(x=> x.id == id).FirstOrDefault();
                return _cliente;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Cliente();
            }
        }

        public bool Create(Cliente model)
        {
            try
            {
                _db.Cliente.Add(model);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(Cliente cliente)
        {
            try {
                var datos = _db.Cliente.FirstOrDefault(s => s.id == cliente.id);
        
                datos.id = cliente.id;
                datos.Nombre = cliente.Nombre;
                datos.Telefono = cliente.Telefono;
                datos.NoCelular = cliente.NoCelular;
                datos.RazonSocial = cliente.RazonSocial;
                datos.RFC = cliente.RFC;
                datos.Domicilio = cliente.Domicilio;
                datos.Colonia = cliente.Colonia;
                datos.Municipio = cliente.Municipio;
                datos.idEstado = cliente.idEstado;
                datos.Estado = cliente.Estado;
                datos.CodigoPostal = cliente.CodigoPostal;
                datos.idMunicipio = cliente.idMunicipio;
                datos.HorarioPorDefecto = cliente.HorarioPorDefecto;
                datos.ISR = cliente.ISR;
                datos.IVA = cliente.IVA;
                datos.Estatus = true;
                datos.FechaRegistro = DateTime.Now;
                _db.Update(datos);
                _db.SaveChanges();

                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public List<SelectListItem> GetListaEstados()
        {
            try
            {
                var list = _db.Estados.Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SelectListItem>();
            }
        }

        public List<SelectListItem> GetListaMunicipios()
        {
            try
            {
                var list = _db.Municipios.Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SelectListItem>();
            }
        }
   
        public List<SelectListItem> GetMunicipiosPorEstado(int id)
        {
            try
            {
                var list = _db.Municipios.Where(x=> x.idEstado == id).Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SelectListItem>();
            }
        }

        public bool Delete(Cliente model)
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
