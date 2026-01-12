using Actividad7.Models;

namespace Actividad7.DataAccess
{
    /// <summary>
    /// Interfaz que define las operaciones de acceso a datos para las matrículas
    /// IMPORTANTE: Usa ID_Alumno (int) como clave foránea, no DNI
    /// </summary>
    public interface IMatriculaRepository
    {
        List<Matricula> GetAllMatriculas();
        List<Matricula> GetMatriculasByAlumno(int idAlumno);        // ? CORREGIDO: Usar int
        List<Matricula> GetMatriculasByAlumnoDni(string dni);       // ? AÑADIDO: Para compatibilidad
        List<Matricula> GetMatriculasByAsignatura(int idAsignatura);
        bool MatricularAlumno(int idAlumno, int idAsignatura);      // ? CORREGIDO: Usar int
        bool ActualizarNota(int idMatricula, decimal nota, string estado);
        bool EliminarMatricula(int idMatricula);
        bool ExisteMatricula(int idAlumno, int idAsignatura);       // ? CORREGIDO: Usar int
    }
}