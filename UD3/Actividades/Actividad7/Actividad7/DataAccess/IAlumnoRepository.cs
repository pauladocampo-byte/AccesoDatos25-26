using Actividad7.Models;

namespace Actividad7.DataAccess
{
    /// <summary>
    /// Interfaz que define las operaciones de acceso a datos para los alumnos
    /// IMPORTANTE: Los alumnos tienen Id como clave primaria y DNI como campo único
    /// </summary>
    public interface IAlumnoRepository
    {
        List<Alumno> GetAllAlumnos();
        bool InsertAlumno(Alumno alumno);
        Alumno? GetAlumnoByDni(string dni);
        Alumno? GetAlumnoById(int id);              // ? AÑADIDO: Método para buscar por Id
        bool UpdateAlumno(Alumno alumno);
        bool DeleteAlumno(string dni);
    }
}