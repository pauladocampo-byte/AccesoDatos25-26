using Actividad7.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Actividad7.DataAccess
{
    /// <summary>
    /// Repositorio para el manejo de matrículas (tabla de relación)
    /// IMPORTANTE: Usa ID_Alumno (int) como clave foránea, no DNI
    /// </summary>
    public class MatriculaRepository : IMatriculaRepository, IDisposable
    {
        private readonly SqlConnection _connection;
        private bool _disposed = false;

        public MatriculaRepository(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("Actividad4ConnectionString") 
                ?? throw new InvalidOperationException("Connection string 'Actividad4ConnectionString' not found");
            
            _connection = new SqlConnection(connectionString);
        }

        private void EnsureConnectionOpen()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public List<Matricula> GetAllMatriculas()
        {
            var matriculas = new List<Matricula>();
            
            EnsureConnectionOpen();

            // ? CORREGIDO: Usar ID_Alumno en lugar de DNI_Alumno
            const string consulta = @"
                SELECT 
                    m.ID_Matricula,
                    m.ID_Alumno,                            -- ? CORREGIDO
                    m.ID_Asignatura,
                    m.FechaMatricula,
                    m.Nota,
                    m.Estado,
                    a.DNI AS DNI_Alumno,                    -- ? Para compatibilidad en UI
                    a.Nombre + ' ' + a.Apellidos AS NombreCompleto,
                    asig.Codigo AS CodigoAsignatura,
                    asig.Nombre AS NombreAsignatura,
                    asig.Creditos,
                    asig.Curso
                FROM Matriculas m
                    INNER JOIN Alumnos a ON m.ID_Alumno = a.Id      -- ? CORREGIDO: Join por Id
                    INNER JOIN Asignaturas asig ON m.ID_Asignatura = asig.ID_Asignatura
                ORDER BY a.Apellidos, a.Nombre, asig.Curso, asig.Codigo";
            
            using var comando = new SqlCommand(consulta, _connection);
            using var reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                matriculas.Add(new Matricula
                {
                    ID_Matricula = (int)reader["ID_Matricula"],
                    ID_Alumno = (int)reader["ID_Alumno"],           // ? CORREGIDO
                    ID_Asignatura = (int)reader["ID_Asignatura"],
                    FechaMatricula = (DateTime)reader["FechaMatricula"],
                    Nota = reader["Nota"] as decimal?,
                    Estado = reader["Estado"].ToString() ?? "Matriculado",
                    DNI_Alumno = reader["DNI_Alumno"].ToString(),   // Para compatibilidad
                    NombreCompleto = reader["NombreCompleto"].ToString(),
                    CodigoAsignatura = reader["CodigoAsignatura"].ToString(),
                    NombreAsignatura = reader["NombreAsignatura"].ToString(),
                    Creditos = (int)reader["Creditos"],
                    Curso = (int)reader["Curso"]
                });
            }

            return matriculas;
        }

        public List<Matricula> GetMatriculasByAlumno(int idAlumno)      // ? CORREGIDO: Usar int
        {
            return GetAllMatriculas().Where(m => m.ID_Alumno == idAlumno).ToList();
        }

        public List<Matricula> GetMatriculasByAlumnoDni(string dni)     // ? AÑADIDO: Mantener compatibilidad
        {
            return GetAllMatriculas().Where(m => m.DNI_Alumno == dni).ToList();
        }

        public List<Matricula> GetMatriculasByAsignatura(int idAsignatura)
        {
            return GetAllMatriculas().Where(m => m.ID_Asignatura == idAsignatura).ToList();
        }

        public bool MatricularAlumno(int idAlumno, int idAsignatura)    // ? CORREGIDO: Usar int
        {
            EnsureConnectionOpen();

            // ? CORREGIDO: Usar ID_Alumno en lugar de DNI_Alumno
            const string consulta = @"
                INSERT INTO Matriculas (ID_Alumno, ID_Asignatura, Estado) 
                VALUES (@IDAlumno, @IDAsignatura, 'Matriculado')";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@IDAlumno", idAlumno);
            comando.Parameters.AddWithValue("@IDAsignatura", idAsignatura);

            try
            {
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (SqlException ex)
            {
                // Error de clave duplicada (ya matriculado)
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new InvalidOperationException("El alumno ya está matriculado en esta asignatura.");
                }
                // Error de clave foránea (alumno o asignatura no existe)
                if (ex.Number == 547)
                {
                    throw new InvalidOperationException("El alumno o la asignatura especificada no existe.");
                }
                return false;
            }
        }

        public bool ActualizarNota(int idMatricula, decimal nota, string estado)
        {
            EnsureConnectionOpen();

            const string consulta = @"
                UPDATE Matriculas 
                SET Nota = @Nota, Estado = @Estado 
                WHERE ID_Matricula = @ID";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@ID", idMatricula);
            comando.Parameters.AddWithValue("@Nota", nota);
            comando.Parameters.AddWithValue("@Estado", estado);

            try
            {
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool EliminarMatricula(int idMatricula)
        {
            EnsureConnectionOpen();

            const string consulta = "DELETE FROM Matriculas WHERE ID_Matricula = @ID";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@ID", idMatricula);

            try
            {
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool ExisteMatricula(int idAlumno, int idAsignatura)     // ? CORREGIDO: Usar int
        {
            EnsureConnectionOpen();

            // ? CORREGIDO: Usar ID_Alumno en lugar de DNI_Alumno
            const string consulta = @"
                SELECT COUNT(*) 
                FROM Matriculas 
                WHERE ID_Alumno = @IDAlumno AND ID_Asignatura = @IDAsignatura";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@IDAlumno", idAlumno);
            comando.Parameters.AddWithValue("@IDAsignatura", idAsignatura);

            int count = (int)comando.ExecuteScalar();
            return count > 0;
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _connection?.Close();
                _connection?.Dispose();
                _disposed = true;
            }
        }
    }
}