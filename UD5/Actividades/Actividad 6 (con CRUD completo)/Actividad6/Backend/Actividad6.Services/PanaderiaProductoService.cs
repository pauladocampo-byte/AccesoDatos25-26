using Actividad6.Core;
using Actividad6.Data;
using Microsoft.EntityFrameworkCore;

namespace Actividad6.Services
{
    public class PanaderiaProductoService : IPanaderiaProductoService
    {
        private readonly PanaderiaContext _context;

        public PanaderiaProductoService(PanaderiaContext context)
        {
            _context = context;
        }

        public async Task<List<PanaderiaProducto>> ObtenerRelacionesAsync()
        {
            return await _context.PanaderiasProductos
                .Include(pp => pp.Panaderia)
                .Include(pp => pp.Producto)
                .ToListAsync();
        }

        public async Task<PanaderiaProducto?> ObtenerRelacionAsync(int panaderiaId, int productoId)
        {
            return await _context.PanaderiasProductos
                .Include(pp => pp.Panaderia)
                .Include(pp => pp.Producto)
                .FirstOrDefaultAsync(pp => pp.PanaderiaId == panaderiaId && pp.ProductoId == productoId);
        }

        public async Task<PanaderiaProducto> AgregarRelacionAsync(PanaderiaProducto relacion)
        {
            _context.PanaderiasProductos.Add(relacion);
            await _context.SaveChangesAsync();
            return relacion;
        }

        public async Task<PanaderiaProducto?> ActualizarRelacionAsync(int panaderiaId, int productoId, PanaderiaProducto relacion)
        {
            var existing = await _context.PanaderiasProductos
                .FirstOrDefaultAsync(pp => pp.PanaderiaId == panaderiaId && pp.ProductoId == productoId);

            if (existing == null) return null;

            existing.Precio = relacion.Precio;
            existing.Stock = relacion.Stock;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> EliminarRelacionAsync(int panaderiaId, int productoId)
        {
            var relacion = await _context.PanaderiasProductos
                .FirstOrDefaultAsync(pp => pp.PanaderiaId == panaderiaId && pp.ProductoId == productoId);

            if (relacion == null) return false;

            _context.PanaderiasProductos.Remove(relacion);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
