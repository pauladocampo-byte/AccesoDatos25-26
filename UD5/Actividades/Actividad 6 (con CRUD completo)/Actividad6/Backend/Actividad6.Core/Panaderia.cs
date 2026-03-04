namespace Actividad6.Core
{
    public class Panaderia
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;

        // Relación muchos a muchos con Producto
        public List<PanaderiaProducto> PanaderiasProductos { get; set; } = new List<PanaderiaProducto>();
    }
}
