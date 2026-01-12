namespace Actividad7.Models
{
    /// <summary>
    /// Modelo que representa un alumno
    /// IMPORTANTE: La clave primaria es Id, DNI es único pero no es clave primaria
    /// </summary>
    public class Alumno
    {
        public int Id { get; set; }                     // ? CORREGIDO: Clave primaria
        public string DNI { get; set; } = string.Empty; // Campo único pero no clave primaria
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

        /// <summary>
        /// Representación que incluye el ID para debugging
        /// </summary>
        public string ToDebugString()
        {
            return $"[{Id}] {Apellidos}, {Nombre} ({DNI})";
        }
    }
}