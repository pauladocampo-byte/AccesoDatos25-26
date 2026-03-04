using Actividad6.Core;
using Actividad6.Data;
using Microsoft.EntityFrameworkCore;

namespace Actividad6.Services
{
    public class ProductoService : IProductoService
    {
        private readonly PanaderiaContext _context;

        public ProductoService(PanaderiaContext context)
        {
            _context = context;
        }

        public async Task<List<Producto>> ObtenerProductosAsync()
        {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto?> ObtenerProductoPorIdAsync(int id)
        {
            return await _context.Productos.FindAsync(id);
        }

        public async Task<Producto> AgregarProductoAsync(Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task<Producto?> ActualizarProductoAsync(int id, Producto producto)
        {
            var existing = await _context.Productos.FindAsync(id);
            if (existing == null) return null;

            existing.Nombre = producto.Nombre;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> EliminarProductoAsync(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            if (producto == null) return false;

            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
