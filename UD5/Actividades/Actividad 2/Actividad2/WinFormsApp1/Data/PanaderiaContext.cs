using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Data;

namespace Actividad1.Data
{
    public partial class PanaderiaContext : DbContext
    {
        public PanaderiaContext(DbContextOptions<PanaderiaContext> options)
            :base(options)
        {
        }

        public PanaderiaContext()
        {
        }

        public DbSet<Producto> Productos { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=PO235PDOCAMPO\\SQLEXPRESS;Database=PanaderiaDB;Trusted_Connection=True;TrustServerCertificate=True;");
        //}
    }
}
