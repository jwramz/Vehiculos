using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIVA.Modelos.Models;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IContenedorTrabajo : IDisposable
    {

        ICliente Cliente { get; }
        IComprador Comprador { get; }
        IVendedor Vendedor { get; }
        IVehiculo Vehiculo { get; }

        IAModelo AModelo { get; }
        IOficina Oficina { get; }
        IMunicipio Municipio { get; }
        IEstado Estado { get; }
        IColorVehiculo ColorVehiculo { get; }
        IMarca  Marca { get; }
        IModelo Modelo { get;}


        void Save();

    }
}
