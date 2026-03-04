using Actividad6.Core;

namespace Actividad6.Services
{
    public interface IPanaderiaService
    {
        Task<List<Panaderia>> ObtenerPanaderiasAsync();
        Task<Panaderia?> ObtenerPanaderiaPorIdAsync(int id);
        Task<Panaderia> AgregarPanaderiaAsync(Panaderia panaderia);
        Task<Panaderia?> ActualizarPanaderiaAsync(int id, Panaderia panaderia);
        Task<bool> EliminarPanaderiaAsync(int id);
    }
}
