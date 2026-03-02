using Actividad5.Core;
using Actividad5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Services
{
    public class ProductoService : IProductoService
    {
        private readonly PanaderiaContext _context;

        public ProductoService(PanaderiaContext context)
        {
            _context = context;
        }

        public List<Producto> ObtenerTodos()
        {
            return _context.Productos.ToList();
        }

        public Producto? ObtenerPorId(int id)
        {
            return _context.Productos.Find(id);
        }

        public void Crear(Producto producto)
        {
            _context.Productos.Add(producto);
            _context.SaveChanges();
        }

        public void Actualizar(Producto producto)
        {
            _context.Productos.Update(producto);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto != null)
            {
                _context.Productos.Remove(producto);
                _context.SaveChanges();
            }
        }
    }
}
