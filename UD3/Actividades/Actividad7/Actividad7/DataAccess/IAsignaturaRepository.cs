using Actividad7.Models;

namespace Actividad7.DataAccess
{
    /// <summary>
    /// Interfaz que define las operaciones de acceso a datos para las asignaturas
    /// </summary>
    public interface IAsignaturaRepository
    {
        List<Asignatura> GetAllAsignaturas();
        List<Asignatura> GetAsignaturasActivas();
        Asignatura? GetAsignaturaById(int id);
        bool InsertAsignatura(Asignatura asignatura);
        bool UpdateAsignatura(Asignatura asignatura);
        bool DeleteAsignatura(int id);
    }
}