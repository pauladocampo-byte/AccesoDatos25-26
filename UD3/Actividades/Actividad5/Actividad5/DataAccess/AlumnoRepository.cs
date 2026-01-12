using Actividad5.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Actividad5.DataAccess
{
    /// <summary>
    /// Clase encargada del acceso a la base de datos para los alumnos
    /// Implementa la separación de responsabilidades
    /// </summary>
    public class AlumnoRepository : IAlumnoRepository, IDisposable
    {
        private readonly SqlConnection _connection;
        private bool _disposed = false;

        public AlumnoRepository(IConfiguration configuration)
        {
            string connectionString = configuration.GetConnectionString("Actividad4ConnectionString") 
                ?? throw new InvalidOperationException("Connection string 'Actividad4ConnectionString' not found");
            
            _connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Abre la conexión a la base de datos si no está abierta
        /// </summary>
        private void EnsureConnectionOpen()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        /// <summary>
        /// Obtiene todos los alumnos de la base de datos
        /// </summary>
        public List<Alumno> GetAllAlumnos()
        {
            var alumnos = new List<Alumno>();
            
            EnsureConnectionOpen();

            const string consulta = "SELECT DNI, Nombre, Apellidos FROM Alumnos ORDER BY Apellidos, Nombre";
            
            using var comando = new SqlCommand(consulta, _connection);
            using var reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                alumnos.Add(new Alumno
                {
                    DNI = reader["DNI"].ToString() ?? string.Empty,
                    Nombre = reader["Nombre"].ToString() ?? string.Empty,
                    Apellidos = reader["Apellidos"].ToString() ?? string.Empty
                });
            }

            return alumnos;
        }

        /// <summary>
        /// Inserta un nuevo alumno en la base de datos
        /// </summary>
        public bool InsertAlumno(Alumno alumno)
        {
            if (alumno == null)
                throw new ArgumentNullException(nameof(alumno));

            EnsureConnectionOpen();

            const string consulta = "INSERT INTO Alumnos (DNI, Nombre, Apellidos) VALUES (@DNI, @Nombre, @Apellidos)";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@DNI", alumno.DNI);
            comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", alumno.Apellidos);

            try
            {
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (SqlException)
            {
                // Log the exception if needed
                return false;
            }
        }

        /// <summary>
        /// Obtiene un alumno por su DNI
        /// </summary>
        public Alumno? GetAlumnoByDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return null;

            EnsureConnectionOpen();

            const string consulta = "SELECT DNI, Nombre, Apellidos FROM Alumnos WHERE DNI = @DNI";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@DNI", dni);
            
            using var reader = comando.ExecuteReader();
            
            if (reader.Read())
            {
                return new Alumno
                {
                    DNI = reader["DNI"].ToString() ?? string.Empty,
                    Nombre = reader["Nombre"].ToString() ?? string.Empty,
                    Apellidos = reader["Apellidos"].ToString() ?? string.Empty
                };
            }

            return null;
        }

        /// <summary>
        /// Actualiza los datos de un alumno
        /// </summary>
        public bool UpdateAlumno(Alumno alumno)
        {
            if (alumno == null)
                throw new ArgumentNullException(nameof(alumno));

            EnsureConnectionOpen();

            const string consulta = "UPDATE Alumnos SET Nombre = @Nombre, Apellidos = @Apellidos WHERE DNI = @DNI";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@DNI", alumno.DNI);
            comando.Parameters.AddWithValue("@Nombre", alumno.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", alumno.Apellidos);

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

        /// <summary>
        /// Elimina un alumno por su DNI
        /// </summary>
        public bool DeleteAlumno(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                return false;

            EnsureConnectionOpen();

            const string consulta = "DELETE FROM Alumnos WHERE DNI = @DNI";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@DNI", dni);

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

        #region IDisposable Implementation

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _connection?.Close();
                _connection?.Dispose();
                _disposed = true;
            }
        }

        #endregion
    }
}