using Actividad6.Core;

namespace Actividad6.Services
{
    public interface IPanaderiaProductoService
    {
        Task<List<PanaderiaProducto>> ObtenerRelacionesAsync();
        Task<PanaderiaProducto?> ObtenerRelacionAsync(int panaderiaId, int productoId);
        Task<PanaderiaProducto> AgregarRelacionAsync(PanaderiaProducto relacion);
        Task<PanaderiaProducto?> ActualizarRelacionAsync(int panaderiaId, int productoId, PanaderiaProducto relacion);
        Task<bool> EliminarRelacionAsync(int panaderiaId, int productoId);
    }
}
