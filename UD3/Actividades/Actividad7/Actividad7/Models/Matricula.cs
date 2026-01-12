namespace Actividad7.Models
{
    /// <summary>
    /// Modelo que representa la matrícula de un alumno en una asignatura
    /// IMPORTANTE: Usa ID_Alumno (int) como clave foránea, no DNI
    /// </summary>
    public class Matricula
    {
        public int ID_Matricula { get; set; }
        public int ID_Alumno { get; set; }              // ? CORREGIDO: Usar ID del alumno
        public int ID_Asignatura { get; set; }
        public DateTime FechaMatricula { get; set; }
        public decimal? Nota { get; set; }
        public string Estado { get; set; } = "Matriculado";

        // Propiedades de navegación (para cuando cargamos datos relacionados)
        public string? DNI_Alumno { get; set; }         // Para mantener compatibilidad en la UI
        public string? NombreCompleto { get; set; }
        public string? CodigoAsignatura { get; set; }
        public string? NombreAsignatura { get; set; }
        public int? Creditos { get; set; }
        public int? Curso { get; set; }

        public override string ToString()
        {
            return $"{NombreCompleto} - {CodigoAsignatura} - {Estado}";
        }

        /// <summary>
        /// Representación para mostrar en ListBox con información completa
        /// </summary>
        public string ToDisplayString()
        {
            var notaTexto = Nota.HasValue ? $"Nota: {Nota:F1}" : "Sin calificar";
            return $"{NombreCompleto} ? {CodigoAsignatura} ({Estado}) - {notaTexto}";
        }

        /// <summary>
        /// Representación compacta para mostrar solo la asignatura
        /// </summary>
        public string AsignaturaDisplay()
        {
            return $"{CodigoAsignatura} - {NombreAsignatura}";
        }

        /// <summary>
        /// Representación que incluye IDs para debugging
        /// </summary>
        public string ToDebugString()
        {
            return $"[M:{ID_Matricula}] Alumno[{ID_Alumno}] ? Asignatura[{ID_Asignatura}] - {Estado}";
        }
    }
}