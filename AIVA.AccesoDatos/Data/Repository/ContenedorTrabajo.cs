using AIVA.AccesoDatos.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data.Repository
{
    public class ContenedorTrabajo : IContenedorTrabajo
    {

        private readonly ApplicationDbContext _db;

        public ContenedorTrabajo(ApplicationDbContext db)
        {
            _db = db;
            Cliente = new ClienteRepository(_db);
            Vehiculo = new VehiculoRepository(_db);
            Vendedor = new VendedorRepository(_db);
            Comprador = new CompradorRepository(_db);
            Municipio = new MunicipioRepository(_db);
            Estado = new EstadoRepository(_db);
            ColorVehiculo = new ColorVehiculoRepository(_db);
            AModelo = new AModeloRepository(_db);
            Marca = new MarcaRepository(_db);
            Modelo = new ModeloRepository(_db);
            Oficina = new OficinaRepository(_db);
        }

        public ICliente Cliente { get; private set; }

        public IComprador Comprador { get; private set; }

        public IVendedor Vendedor { get; private set; }

        public IVehiculo Vehiculo { get; private set; }

        public IAModelo AModelo { get; private set; }

        public IOficina Oficina  { get; private set; }

        public IMunicipio Municipio { get; private set; }

        public IEstado Estado { get; private set; }

        public IColorVehiculo ColorVehiculo { get; private set; }

        public IMarca Marca { get; private set; }

        public IModelo Modelo { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.Dispose();
        }
    }
}
