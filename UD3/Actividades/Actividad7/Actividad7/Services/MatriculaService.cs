using Actividad7.Models;
using Actividad7.DataAccess;

namespace Actividad7.Services
{
    /// <summary>
    /// Interfaz para el servicio de matrículas
    /// </summary>
    public interface IMatriculaService
    {
        List<Matricula> GetAllMatriculas();
        List<Matricula> GetMatriculasByAlumnoDni(string dni);       // Mantener compatibilidad con UI
        List<Asignatura> GetAsignaturasDisponibles();
        (bool Success, string Message) MatricularAlumno(string dni, int idAsignatura);
        (bool Success, string Message) ActualizarNota(int idMatricula, decimal nota);
        (bool Success, string Message) EliminarMatricula(int idMatricula);
        bool ExisteMatricula(string dni, int idAsignatura);
    }

    /// <summary>
    /// Servicio que maneja la lógica de negocio para las matrículas
    /// IMPORTANTE: Internamente trabaja con IDs, pero expone interfaz compatible con DNI para la UI
    /// </summary>
    public class MatriculaService : IMatriculaService
    {
        private readonly IMatriculaRepository _matriculaRepository;
        private readonly IAsignaturaRepository _asignaturaRepository;
        private readonly IAlumnoRepository _alumnoRepository;

        public MatriculaService(
            IMatriculaRepository matriculaRepository, 
            IAsignaturaRepository asignaturaRepository,
            IAlumnoRepository alumnoRepository)
        {
            _matriculaRepository = matriculaRepository ?? throw new ArgumentNullException(nameof(matriculaRepository));
            _asignaturaRepository = asignaturaRepository ?? throw new ArgumentNullException(nameof(asignaturaRepository));
            _alumnoRepository = alumnoRepository ?? throw new ArgumentNullException(nameof(alumnoRepository));
        }

        public List<Matricula> GetAllMatriculas()
        {
            return _matriculaRepository.GetAllMatriculas();
        }

        public List<Matricula> GetMatriculasByAlumnoDni(string dni)
        {
            return _matriculaRepository.GetMatriculasByAlumnoDni(dni);
        }

        public List<Asignatura> GetAsignaturasDisponibles()
        {
            return _asignaturaRepository.GetAsignaturasActivas();
        }

        public (bool Success, string Message) MatricularAlumno(string dni, int idAsignatura)
        {
            // ? CORREGIDO: Obtener el alumno completo para tener su Id
            var alumno = _alumnoRepository.GetAlumnoByDni(dni);
            if (alumno == null)
            {
                return (false, "El alumno especificado no existe");
            }

            // Validar que la asignatura existe y está activa
            var asignatura = _asignaturaRepository.GetAsignaturaById(idAsignatura);
            if (asignatura == null || !asignatura.Activa)
            {
                return (false, "La asignatura especificada no existe o no está activa");
            }

            // ? CORREGIDO: Usar el Id del alumno para la validación
            if (_matriculaRepository.ExisteMatricula(alumno.Id, idAsignatura))
            {
                return (false, $"El alumno ya está matriculado en {asignatura.Codigo} - {asignatura.Nombre}");
            }

            try
            {
                // ? CORREGIDO: Pasar el Id del alumno, no el DNI
                bool success = _matriculaRepository.MatricularAlumno(alumno.Id, idAsignatura);
                return success 
                    ? (true, $"? Matrícula exitosa: {alumno.ToDisplayString()} ? {asignatura.Codigo}")
                    : (false, "Error al realizar la matrícula");
            }
            catch (InvalidOperationException ex)
            {
                return (false, $"?? INTEGRIDAD REFERENCIAL: {ex.Message}");
            }
        }

        public (bool Success, string Message) ActualizarNota(int idMatricula, decimal nota)
        {
            if (nota < 0 || nota > 10)
            {
                return (false, "La nota debe estar entre 0 y 10");
            }

            string estado = nota >= 5 ? "Aprobado" : "Suspendido";

            bool success = _matriculaRepository.ActualizarNota(idMatricula, nota, estado);
            return success 
                ? (true, $"Nota actualizada: {nota:F1} - {estado}")
                : (false, "Error al actualizar la nota");
        }

        public (bool Success, string Message) EliminarMatricula(int idMatricula)
        {
            bool success = _matriculaRepository.EliminarMatricula(idMatricula);
            return success 
                ? (true, "Matrícula eliminada exitosamente")
                : (false, "Error al eliminar la matrícula");
        }

        public bool ExisteMatricula(string dni, int idAsignatura)
        {
            // ? CORREGIDO: Convertir DNI a Id para la validación
            var alumno = _alumnoRepository.GetAlumnoByDni(dni);
            if (alumno == null) return false;
            
            return _matriculaRepository.ExisteMatricula(alumno.Id, idAsignatura);
        }
    }
}