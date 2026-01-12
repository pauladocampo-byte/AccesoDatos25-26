using Actividad5.Models;

namespace Actividad5.DataAccess
{
    /// <summary>
    /// Interfaz que define las operaciones de acceso a datos para los alumnos
    /// </summary>
    public interface IAlumnoRepository
    {
        List<Alumno> GetAllAlumnos();
        bool InsertAlumno(Alumno alumno);
        Alumno? GetAlumnoByDni(string dni);
        bool UpdateAlumno(Alumno alumno);
        bool DeleteAlumno(string dni);
    }
}