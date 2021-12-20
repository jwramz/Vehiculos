using AIVA.Modelos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIVA.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Comprador> Comprador { get; set; }
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<SubMarca> Modelo { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Oficina> Oficina { get; set; }
        public DbSet<AnioModelo> AModelo { get; set; }

        public DbSet<Estados> Estados { get; set; }

        public DbSet<Municipio> Municipios { get; set; }

        public DbSet<ColoresVehiculos> PinturaVehiculo { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

       

    }
}
