namespace Actividad6.Core
{
    public class PanaderiaProducto
    {
        public int PanaderiaId { get; set; }
        public Panaderia? Panaderia { get; set; }

        public int ProductoId { get; set; }
        public Producto? Producto { get; set; }

        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
