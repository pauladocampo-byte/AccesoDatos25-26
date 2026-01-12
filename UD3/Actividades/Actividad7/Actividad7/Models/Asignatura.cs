namespace Actividad7.Models
{
    /// <summary>
    /// Modelo que representa una asignatura
    /// </summary>
    public class Asignatura
    {
        public int ID_Asignatura { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public int Creditos { get; set; }
        public int Curso { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activa { get; set; }

        public override string ToString()
        {
            return $"{Codigo} - {Nombre}";
        }

        /// <summary>
        /// Representación para mostrar en ListBox con información completa
        /// </summary>
        public string ToDisplayString()
        {
            return $"{Codigo} - {Nombre} ({Creditos} créditos, Curso {Curso})";
        }
    }
}