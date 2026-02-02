using Actividad3.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.DataAccess.OpcionCon_IConfiguration
{

    /// <summary>
    /// "La opción con IConfiguration es más directa y fácil de entender, 
    /// pero acopla el repositorio a un proveedor específico (SQL Server).
    /// La opción con IDbConnectionFactory añade una capa de abstracción 
    /// que permite cambiar de base de datos sin tocar los repositorios. 
    /// En proyectos reales, esta flexibilidad compensa el código extra."
    /// </summary>
    public class EquipoRepository : IEquipoRepository
    {
        private readonly string _connectionString;

        public EquipoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }


        public IEnumerable<Equipo> GetAll()
        {
            using var connection = new SqlConnection(_connectionString);
            const string sql = "SELECT * FROM Equipos";
            return connection.Query<Equipo>(sql);
        }

        public Equipo? GetByCodigo(string codigo)
        {
            using var connection = new SqlConnection(_connectionString);
            const string sql = "SELECT * FROM Equipos WHERE Codigo = @Codigo";
            return connection.QueryFirstOrDefault<Equipo>(sql, new { Codigo = codigo });
        }

        public int Insert(Equipo equipo)
        {
            using var connection = new SqlConnection(_connectionString);
            const string sql = @"
            INSERT INTO Equipos (Codigo, Nombre, Pais, Estadio, Ciudad) 
            VALUES (@Codigo, @Nombre, @Pais, @Estadio, @Ciudad)";
            return connection.Execute(sql, equipo);
        }

        public int Update(Equipo equipo)
        {
            using var connection = new SqlConnection(_connectionString);
            const string sql = @"
            UPDATE Equipos 
            SET Nombre = @Nombre, 
                Pais = @Pais, 
                Estadio = @Estadio, 
                Ciudad = @Ciudad 
            WHERE Codigo = @Codigo";
            return connection.Execute(sql, equipo);
        }

        public int Delete(string codigo)
        {
            using var connection = new SqlConnection(_connectionString);
            const string sql = "DELETE FROM Equipos WHERE Codigo = @Codigo";
            return connection.Execute(sql, new { Codigo = codigo });
        }
    }
}
