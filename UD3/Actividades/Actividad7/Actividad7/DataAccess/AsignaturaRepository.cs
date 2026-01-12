using Actividad7.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Actividad7.DataAccess
{
    /// <summary>
    /// Repositorio para el manejo de asignaturas
    /// </summary>
    public class AsignaturaRepository : IAsignaturaRepository, IDisposable
    {
        private readonly SqlConnection _connection;
        private bool _disposed = false;

        public AsignaturaRepository(IConfiguration configuration)
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

        public List<Asignatura> GetAllAsignaturas()
        {
            var asignaturas = new List<Asignatura>();
            
            EnsureConnectionOpen();

            const string consulta = @"
                SELECT ID_Asignatura, Codigo, Nombre, Creditos, Curso, FechaCreacion, Activa 
                FROM Asignaturas 
                ORDER BY Curso, Codigo";
            
            using var comando = new SqlCommand(consulta, _connection);
            using var reader = comando.ExecuteReader();
            
            while (reader.Read())
            {
                asignaturas.Add(new Asignatura
                {
                    ID_Asignatura = (int)reader["ID_Asignatura"],
                    Codigo = reader["Codigo"].ToString() ?? string.Empty,
                    Nombre = reader["Nombre"].ToString() ?? string.Empty,
                    Creditos = (int)reader["Creditos"],
                    Curso = (int)reader["Curso"],
                    FechaCreacion = (DateTime)reader["FechaCreacion"],
                    Activa = (bool)reader["Activa"]
                });
            }

            return asignaturas;
        }

        public List<Asignatura> GetAsignaturasActivas()
        {
            return GetAllAsignaturas().Where(a => a.Activa).ToList();
        }

        public Asignatura? GetAsignaturaById(int id)
        {
            EnsureConnectionOpen();

            const string consulta = @"
                SELECT ID_Asignatura, Codigo, Nombre, Creditos, Curso, FechaCreacion, Activa 
                FROM Asignaturas 
                WHERE ID_Asignatura = @ID";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@ID", id);
            
            using var reader = comando.ExecuteReader();
            
            if (reader.Read())
            {
                return new Asignatura
                {
                    ID_Asignatura = (int)reader["ID_Asignatura"],
                    Codigo = reader["Codigo"].ToString() ?? string.Empty,
                    Nombre = reader["Nombre"].ToString() ?? string.Empty,
                    Creditos = (int)reader["Creditos"],
                    Curso = (int)reader["Curso"],
                    FechaCreacion = (DateTime)reader["FechaCreacion"],
                    Activa = (bool)reader["Activa"]
                };
            }

            return null;
        }

        public bool InsertAsignatura(Asignatura asignatura)
        {
            if (asignatura == null)
                throw new ArgumentNullException(nameof(asignatura));

            EnsureConnectionOpen();

            const string consulta = @"
                INSERT INTO Asignaturas (Codigo, Nombre, Creditos, Curso, Activa) 
                VALUES (@Codigo, @Nombre, @Creditos, @Curso, @Activa)";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@Codigo", asignatura.Codigo);
            comando.Parameters.AddWithValue("@Nombre", asignatura.Nombre);
            comando.Parameters.AddWithValue("@Creditos", asignatura.Creditos);
            comando.Parameters.AddWithValue("@Curso", asignatura.Curso);
            comando.Parameters.AddWithValue("@Activa", asignatura.Activa);

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

        public bool UpdateAsignatura(Asignatura asignatura)
        {
            if (asignatura == null)
                throw new ArgumentNullException(nameof(asignatura));

            EnsureConnectionOpen();

            const string consulta = @"
                UPDATE Asignaturas 
                SET Codigo = @Codigo, Nombre = @Nombre, Creditos = @Creditos, 
                    Curso = @Curso, Activa = @Activa 
                WHERE ID_Asignatura = @ID";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@ID", asignatura.ID_Asignatura);
            comando.Parameters.AddWithValue("@Codigo", asignatura.Codigo);
            comando.Parameters.AddWithValue("@Nombre", asignatura.Nombre);
            comando.Parameters.AddWithValue("@Creditos", asignatura.Creditos);
            comando.Parameters.AddWithValue("@Curso", asignatura.Curso);
            comando.Parameters.AddWithValue("@Activa", asignatura.Activa);

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

        public bool DeleteAsignatura(int id)
        {
            EnsureConnectionOpen();

            const string consulta = "DELETE FROM Asignaturas WHERE ID_Asignatura = @ID";
            
            using var comando = new SqlCommand(consulta, _connection);
            comando.Parameters.AddWithValue("@ID", id);

            try
            {
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Foreign key constraint error
                {
                    throw new InvalidOperationException(
                        $"No se puede eliminar la asignatura porque tiene matrículas asociadas. " +
                        $"Primero debe eliminar todas las matrículas.", ex);
                }
                return false;
            }
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