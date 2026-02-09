using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actividad4.Data;

namespace Actividad4.Data
{
    public partial class PanaderiaContext : DbContext
    {
        public PanaderiaContext(DbContextOptions<PanaderiaContext> options)
            : base(options)
        {
        }

        public PanaderiaContext()
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Panaderia> Panaderias { get; set; }
        public DbSet<PanaderiaProducto> PanaderiaProductos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PanaderiaProducto>()
                .HasKey(pp => new { pp.PanaderiaId, pp.ProductoId }); // Clave compuesta

            modelBuilder.Entity<PanaderiaProducto>()
                .HasOne(pp => pp.Panaderia)
                .WithMany(p => p.PanaderiaProductos)
                .HasForeignKey(pp => pp.PanaderiaId);

            modelBuilder.Entity<PanaderiaProducto>()
                .HasOne(pp => pp.Producto)
                .WithMany(p => p.PanaderiaProductos)
                .HasForeignKey(pp => pp.ProductoId);
        }
    }
}
