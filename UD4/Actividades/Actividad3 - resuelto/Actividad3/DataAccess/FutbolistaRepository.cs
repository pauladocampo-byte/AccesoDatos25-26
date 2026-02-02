using Actividad3.Data;
using Actividad3.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.DataAccess
{
    public  class FutbolistaRepository : IFutbolistaRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public FutbolistaRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public IEnumerable<Futbolista> GetAll()
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = "SELECT * FROM Futbolistas";
            return connection.Query<Futbolista>(sql);
        }

        public Futbolista? GetByCodigo(string codigo)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = "SELECT * FROM Futbolistas WHERE Codigo = @Codigo";
            return connection.QueryFirstOrDefault<Futbolista>(sql, new { Codigo = codigo });
        }

        public IEnumerable<Futbolista> GetByEquipoCodigo(string codigoEquipo)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = "SELECT * FROM Futbolistas WHERE CodigoEquipo = @CodigoEquipo";
            return connection.Query<Futbolista>(sql, new { CodigoEquipo = codigoEquipo });
        }

        public IEnumerable<Futbolista> GetByEquipoNombre(string nombreEquipo)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = @"
            SELECT F.* 
            FROM Futbolistas F 
            INNER JOIN Equipos E ON F.CodigoEquipo = E.Codigo 
            WHERE E.Nombre = @NombreEquipo";
            return connection.Query<Futbolista>(sql, new { NombreEquipo = nombreEquipo });
        }

        public int Insert(Futbolista futbolista)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = @"
            INSERT INTO Futbolistas (Codigo, Nombre, CodigoEquipo, Posicion, Edad, Dorsal) 
            VALUES (@Codigo, @Nombre, @CodigoEquipo, @Posicion, @Edad, @Dorsal)";
            return connection.Execute(sql, futbolista);
        }

        public int Update(Futbolista futbolista)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = @"
            UPDATE Futbolistas 
            SET Nombre = @Nombre, 
                Posicion = @Posicion, 
                Edad = @Edad, 
                Dorsal = @Dorsal,
                CodigoEquipo = @CodigoEquipo
            WHERE Codigo = @Codigo";
            return connection.Execute(sql, futbolista);
        }

        public int Delete(string codigo)
        {
            using var connection = _connectionFactory.CreateConnection();
            const string sql = "DELETE FROM Futbolistas WHERE Codigo = @Codigo";
            return connection.Execute(sql, new { Codigo = codigo });
        }
    }
}
