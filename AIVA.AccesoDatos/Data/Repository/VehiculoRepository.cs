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
    public class VehiculoRepository : Repository<Vehiculo>, IVehiculo
    {
        private readonly ApplicationDbContext _db;

        public VehiculoRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public List<Vehiculo> GetVehiculos()
        {

            try
            {
                var list = _db.Vehiculo.ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Vehiculo>();
            }
        }

        public Vehiculo GetVehiculoById(int id)
        {
            try
            {
                Vehiculo _vehiculo = new Vehiculo();
                _vehiculo = _db.Vehiculo.Where(x => x.id == id).FirstOrDefault();
                return _vehiculo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new Vehiculo();
            }
        }

        public bool Create(Vehiculo model)
        {
            try
            {
                model.Estatus = true;
                
                _db.Vehiculo.Add(model);
                _db.SaveChanges();
               
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Update(Vehiculo vehiculo)
        {
            try
            {
                var datos = _db.Vehiculo.FirstOrDefault(s => s.id == vehiculo.id);

                datos.id = vehiculo.id;
            
                datos.Marca = vehiculo.Marca;
                datos.idMarca = vehiculo.idMarca;
                
                datos.SubMarca = vehiculo.SubMarca;
                datos.idSubMarca = vehiculo.idSubMarca;

                datos.Modelo = vehiculo.Modelo;
                datos.idModelo = vehiculo.idModelo;

                datos.Color = vehiculo.Color;
                datos.idColor = vehiculo.idColor;

                datos.NoSerie = vehiculo.NoSerie;
                datos.NoPlaca = vehiculo.NoPlaca;
                datos.NoMotor = vehiculo.NoMotor;

                datos.TipoVehiculo = vehiculo.TipoVehiculo;

                datos.Estado = vehiculo.Estado;
                datos.idEstado = vehiculo.idEstado;

                datos.idPais = vehiculo.idPais;
                datos.idComprador = vehiculo.idComprador;
                datos.idVendedor = vehiculo.idVendedor;

                datos.procedencia = vehiculo.procedencia;
                datos.CincoDigitos = vehiculo.CincoDigitos;

                datos.Observaciones = vehiculo.Observaciones;
                datos.TipoReporte = vehiculo.TipoReporte;
                datos.DocumentosAprocrifos = vehiculo.DocumentosAprocrifos;
                datos.NumeracionAlterada = vehiculo.NumeracionAlterada;
                datos.ReciboNumero = vehiculo.ReciboNumero;
                datos.Recibio = vehiculo.Recibio;
                datos.Pago = vehiculo.Pago;
                datos.NumeroResponsiva = vehiculo.NumeroResponsiva;
                datos.LugarRevision = vehiculo.LugarRevision;
                datos.UsuarioRegistro = vehiculo.UsuarioRegistro;
                datos.Ficha = vehiculo.Ficha;

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

        public List<SelectListItem> GetListaMarcas()
        {
            try
            {
                var list = _db.Marca.Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SelectListItem>();
            }
        }
        
        public List<SelectListItem> GetListaModelos()
        {
            try
            {
                var list = _db.Modelo.Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SelectListItem>();
            }
        }
   
        public List<SelectListItem> GetListaAModelo()
        {
            try
            {
                var list = _db.AModelo.Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SelectListItem>();
            }
        }

        public List<SelectListItem> GetListaColorVehiculo()
        {
            try
            {
                var list = _db.PinturaVehiculo.Select(x => new SelectListItem() { Text = x.Descripcion, Value = x.id.ToString() }).OrderBy(x => x.Text).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<SelectListItem>();
            }
        }

        public Vehiculo GetVehiculoBySerie(string _noserie)
        {
            try
            {
                Vehiculo _vehiculo = new Vehiculo();
                _vehiculo = _db.Vehiculo.Where(x => x.NoSerie == _noserie).FirstOrDefault();
                return _vehiculo;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
