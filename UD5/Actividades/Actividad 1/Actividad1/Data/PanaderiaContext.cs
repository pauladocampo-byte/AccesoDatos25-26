using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.Data
{
    public partial class PanaderiaContext : DbContext
    {
        public PanaderiaContext(DbContextOptions<PanaderiaContext> options) : base(options)
        {
        }

        public PanaderiaContext()
        {
        }

        public DbSet<Producto> Productos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=PanaderiaDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
