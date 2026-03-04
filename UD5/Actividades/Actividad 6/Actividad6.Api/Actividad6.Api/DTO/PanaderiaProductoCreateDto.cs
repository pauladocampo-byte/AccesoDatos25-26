namespace Actividad6.Api.DTO
{
    public class PanaderiaProductoCreateDto
    {
        public int PanaderiaId { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
