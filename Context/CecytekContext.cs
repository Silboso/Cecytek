using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cecytek.Models;
namespace Cecytek.Context
{
    public class CecytekContext : DbContext
    {
        
        public DbSet<TipoPago> TipoPago { get; set; }

        public DbSet<Recibos> Recibos { get; set; }

        public DbSet<Alumnos> Alumnos { get; set; }

        public DbSet<Carreras> Carreras { get; set; }

        public CecytekContext(DbContextOptions<CecytekContext> options) : base(options) { }
    }
}
