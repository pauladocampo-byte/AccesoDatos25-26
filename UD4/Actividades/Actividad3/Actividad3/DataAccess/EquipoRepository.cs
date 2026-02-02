using Actividad3.Data;
using Actividad3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace Actividad3.DataAccess
{
    public  class EquipoRepository : IEquipoRepository
    {

        private readonly IDbConnectionFactory _connectionFactory;
        public EquipoRepository( IDbConnectionFactory connectionFactory) 
        {
            _connectionFactory = connectionFactory;
        }

        public IEnumerable<Equipo> GetAll()
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = "SELECT * FROM Equipos";
            return connection.Query<Equipo>(sql);
        }

        public int Insert(Equipo equipo)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = "INSERT INTO Equipos (Codigo, Nombre, Pais, Estadio, Ciudad) " +
                               "VALUES (@Codigo, @Nombre, @Pais, @Estadio, @Ciudad); ";
            return connection.Execute(sql, equipo);
        }

        public Equipo? GetEquipoByCodigo(string codigo)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = "SELECT * FROM Equipos WHERE Codigo = @Codigo";
            return connection.QueryFirstOrDefault<Equipo>(sql, new { Codigo = codigo });
        }

        public int Delete(string codigo)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = "DELETE FROM Equipos WHERE Codigo = @Codigo";
            return connection.Execute(sql, new { Codigo = codigo });
        }

        public int Update(Equipo equipo)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = @"
            UPDATE Equipos 
            SET Nombre = @Nombre, 
                Pais = @Pais, 
                Estadio = @Estadio, 
                Ciudad = @Ciudad 
            WHERE Codigo = @Codigo";
            return connection.Execute(sql, equipo);
        }


    }
}
