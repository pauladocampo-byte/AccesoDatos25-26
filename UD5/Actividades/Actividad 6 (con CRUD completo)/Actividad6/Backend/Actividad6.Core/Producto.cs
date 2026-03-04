namespace Actividad6.Core
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        // Relación muchos a muchos con Panaderia
        public List<PanaderiaProducto> PanaderiasProductos { get; set; } = new List<PanaderiaProducto>();
    }
}
