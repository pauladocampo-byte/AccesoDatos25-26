namespace Actividad6.ClienteApi.Models
{
    /// <summary>
    /// Modelo de relación Panadería-Producto para el cliente API
    /// </summary>
    public class PanaderiaProductoDto
    {
        public int PanaderiaId { get; set; }
        public string PanaderiaNombre { get; set; } = string.Empty;
        public int ProductoId { get; set; }
        public string ProductoNombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }

    /// <summary>
    /// DTO para crear una relación Panadería-Producto
    /// </summary>
    public class PanaderiaProductoCreateDto
    {
        public int PanaderiaId { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }

    /// <summary>
    /// DTO para actualizar una relación Panadería-Producto
    /// </summary>
    public class PanaderiaProductoUpdateDto
    {
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
