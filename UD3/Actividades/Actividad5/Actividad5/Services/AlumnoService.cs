using Actividad5.Models;
using Actividad5.DataAccess;

namespace Actividad5.Services
{
    /// <summary>
    /// Interfaz para el servicio de lógica de negocio de alumnos
    /// </summary>
    public interface IAlumnoService
    {
        List<Alumno> GetAllAlumnos();
        (bool Success, string Message) CreateAlumno(Alumno alumno);
        Alumno? GetAlumnoByDni(string dni);
        (bool Success, string Message) UpdateAlumno(Alumno alumno);
        (bool Success, string Message) DeleteAlumno(string dni);
        bool ValidateAlumno(Alumno alumno, out string errorMessage);
    }

    /// <summary>
    /// Servicio que contiene la lógica de negocio para los alumnos
    /// </summary>
    public class AlumnoService : IAlumnoService
    {
        private readonly IAlumnoRepository _alumnoRepository;

        public AlumnoService(IAlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository ?? throw new ArgumentNullException(nameof(alumnoRepository));
        }

        public List<Alumno> GetAllAlumnos()
        {
            return _alumnoRepository.GetAllAlumnos();
        }

        public (bool Success, string Message) CreateAlumno(Alumno alumno)
        {
            // Validación de negocio
            if (!ValidateAlumno(alumno, out string errorMessage))
            {
                return (false, errorMessage);
            }

            // Verificar si el DNI ya existe
            var existingAlumno = _alumnoRepository.GetAlumnoByDni(alumno.DNI);
            if (existingAlumno != null)
            {
                return (false, "Ya existe un alumno con ese DNI");
            }

            // Insertar el alumno
            bool success = _alumnoRepository.InsertAlumno(alumno);
            return success 
                ? (true, "Alumno creado exitosamente")
                : (false, "Error al crear el alumno en la base de datos");
        }

        public Alumno? GetAlumnoByDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return null;

            return _alumnoRepository.GetAlumnoByDni(dni);
        }

        public (bool Success, string Message) UpdateAlumno(Alumno alumno)
        {
            // Validación de negocio
            if (!ValidateAlumno(alumno, out string errorMessage))
            {
                return (false, errorMessage);
            }

            // Verificar que el alumno existe
            var existingAlumno = _alumnoRepository.GetAlumnoByDni(alumno.DNI);
            if (existingAlumno == null)
            {
                return (false, "El alumno no existe");
            }

            // Actualizar el alumno
            bool success = _alumnoRepository.UpdateAlumno(alumno);
            return success 
                ? (true, "Alumno actualizado exitosamente")
                : (false, "Error al actualizar el alumno");
        }

        public (bool Success, string Message) DeleteAlumno(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return (false, "DNI no válido");
            }

            // Verificar que el alumno existe
            var existingAlumno = _alumnoRepository.GetAlumnoByDni(dni);
            if (existingAlumno == null)
            {
                return (false, "El alumno no existe");
            }

            // Eliminar el alumno
            bool success = _alumnoRepository.DeleteAlumno(dni);
            return success 
                ? (true, "Alumno eliminado exitosamente")
                : (false, "Error al eliminar el alumno");
        }

        public bool ValidateAlumno(Alumno alumno, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (alumno == null)
            {
                errorMessage = "El alumno no puede ser nulo";
                return false;
            }

            if (string.IsNullOrWhiteSpace(alumno.DNI))
            {
                errorMessage = "El DNI es obligatorio";
                return false;
            }

            if (alumno.DNI.Length != 9)
            {
                errorMessage = "El DNI debe tener exactamente 9 caracteres";
                return false;
            }

            if (string.IsNullOrWhiteSpace(alumno.Nombre))
            {
                errorMessage = "El nombre es obligatorio";
                return false;
            }

            if (alumno.Nombre.Length > 50)
            {
                errorMessage = "El nombre no puede exceder 50 caracteres";
                return false;
            }

            if (string.IsNullOrWhiteSpace(alumno.Apellidos))
            {
                errorMessage = "Los apellidos son obligatorios";
                return false;
            }

            if (alumno.Apellidos.Length > 50)
            {
                errorMessage = "Los apellidos no pueden exceder 50 caracteres";
                return false;
            }

            return true;
        }
    }
}