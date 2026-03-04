using Actividad6.Core;
using Actividad6.Data;
using Microsoft.EntityFrameworkCore;

namespace Actividad6.Services
{
    public class PanaderiaService : IPanaderiaService
    {
        private readonly PanaderiaContext _context;

        public PanaderiaService(PanaderiaContext context)
        {
            _context = context;
        }

        public async Task<List<Panaderia>> ObtenerPanaderiasAsync()
        {
            return await _context.Panaderias.ToListAsync();
        }

        public async Task<Panaderia?> ObtenerPanaderiaPorIdAsync(int id)
        {
            return await _context.Panaderias.FindAsync(id);
        }

        public async Task<Panaderia> AgregarPanaderiaAsync(Panaderia panaderia)
        {
            _context.Panaderias.Add(panaderia);
            await _context.SaveChangesAsync();
            return panaderia;
        }

        public async Task<Panaderia?> ActualizarPanaderiaAsync(int id, Panaderia panaderia)
        {
            var existing = await _context.Panaderias.FindAsync(id);
            if (existing == null) return null;

            existing.Nombre = panaderia.Nombre;
            existing.Direccion = panaderia.Direccion;
            existing.Telefono = panaderia.Telefono;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> EliminarPanaderiaAsync(int id)
        {
            var panaderia = await _context.Panaderias.FindAsync(id);
            if (panaderia == null) return false;

            _context.Panaderias.Remove(panaderia);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
