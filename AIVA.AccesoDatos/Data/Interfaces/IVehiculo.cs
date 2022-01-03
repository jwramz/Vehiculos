using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AIVA.AccesoDatos.Data.Interfaces
{
    public interface IVehiculo : IRepository<Vehiculo>
    {

        List<Vehiculo> GetVehiculos();

        Vehiculo GetVehiculoById(int id);

        bool Create(Vehiculo model);

        bool Update(Vehiculo vehiculo);

        List<SelectListItem> GetListaEstados();

        List<SelectListItem> GetListaMunicipios();

        List<SelectListItem> GetListaMarcas();

        List<SelectListItem> GetListaModelos();

        List<SelectListItem> GetListaAModelo();

        List<SelectListItem>  GetListaColorVehiculo();

        Vehiculo GetVehiculoBySerie(string _noserie);

        List<ReporteVehiculo> GetReportesVehiculos();

    }
}
