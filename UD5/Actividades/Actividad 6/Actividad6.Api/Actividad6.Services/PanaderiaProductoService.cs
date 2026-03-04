using Actividad6.Core;
using Actividad6.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad6.Services
{
    public class PanaderiaProductoService : IPanaderiaProductoService
    {
        private readonly PanaderiaContext _context;
        public PanaderiaProductoService(PanaderiaContext context)
        {
            _context = context;
        }

        public List<PanaderiaProducto> ObtenerTodas()
        {
            return _context.PanaderiaProductos
                .Include(pp => pp.Panaderia)
                .Include(pp => pp.Producto)
                .ToList();
        }

        //Pbtiene los productos de una panadería
        public List<PanaderiaProducto> ObtenerPorPanaderia(int panaderiaId)
        {
            return _context.PanaderiaProductos
                .Include(pp => pp.Producto)
                .Where(pp => pp.PanaderiaId == panaderiaId)
                .ToList();
        }

        //Optiene las panaderías que venden un producto
        public List<PanaderiaProducto> ObtenerPorProducto(int productoId)
        {
            return _context.PanaderiaProductos
                .Include(pp => pp.Panaderia)
                .Where(pp => pp.ProductoId == productoId)
                .ToList();
        }

        public PanaderiaProducto? ObtenerPorIds(int panaderiaId, int productoId)
        {
            return _context.PanaderiaProductos
                .Include(pp => pp.Panaderia)
                .Include(pp => pp.Producto)
                .FirstOrDefault(pp => pp.PanaderiaId == panaderiaId && pp.ProductoId == productoId);
        }

        public void Crear(PanaderiaProducto relacion)
        {
            _context.PanaderiaProductos.Add(relacion);
            _context.SaveChanges();
        }

        public void Actualizar(PanaderiaProducto relacion)
        {
            _context.PanaderiaProductos.Update(relacion);
            _context.SaveChanges();
        }

        public void Eliminar(int panaderiaId, int productoId)
        {
            var relacion = _context.PanaderiaProductos
                .FirstOrDefault(pp => pp.PanaderiaId == panaderiaId && pp.ProductoId == productoId);

            if (relacion != null)
            {
                _context.PanaderiaProductos.Remove(relacion);
                _context.SaveChanges();
            }
        }

        public bool Existe(int panaderiaId, int productoId)
        {
            return _context.PanaderiaProductos
                .Any(pp => pp.PanaderiaId == panaderiaId && pp.ProductoId == productoId);
        }
    }
}
