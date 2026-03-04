using Actividad6.Core;

namespace Actividad6.Services
{
    public interface IProductoService
    {
        Task<List<Producto>> ObtenerProductosAsync();
        Task<Producto?> ObtenerProductoPorIdAsync(int id);
        Task<Producto> AgregarProductoAsync(Producto producto);
        Task<Producto?> ActualizarProductoAsync(int id, Producto producto);
        Task<bool> EliminarProductoAsync(int id);
    }
}
