namespace Actividad6.Models
{
    /// <summary>
    /// Modelo que representa un alumno
    /// </summary>
    public class Alumno
    {
        public string DNI { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;

        public override string ToString()
        {
            return $"{DNI} - {Nombre} - {Apellidos}";
        }

        /// <summary>
        /// Representación para mostrar en ListBox con mejor formato
        /// </summary>
        public string ToDisplayString()
        {
            return $"{Apellidos}, {Nombre} ({DNI})";
        }
    }
}