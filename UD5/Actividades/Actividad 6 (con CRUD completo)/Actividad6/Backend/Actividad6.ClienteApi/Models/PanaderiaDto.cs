namespace Actividad6.ClienteApi.Models
{
    /// <summary>
    /// Modelo de Panadería para el cliente API
    /// </summary>
    public class PanaderiaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
    }
}
