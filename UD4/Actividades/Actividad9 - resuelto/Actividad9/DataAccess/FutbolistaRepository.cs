using Actividad9.Data;
using Actividad9.Models;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad9.DataAccess
{
    /// <summary>
    /// Repositorio de Futbolistas usando Dapper.Contrib para operaciones CRUD básicas.
    /// Para consultas complejas (JOINs, filtros), seguimos usando Dapper tradicional.
    /// </summary>
    public class FutbolistaRepository : IFutbolistaRepository
    {
        private readonly IDbConnectionFactory _connectionFactory;
        public FutbolistaRepository(IDbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        /// <summary>
        /// Obtiene todos los futbolistas usando GetAll de Dapper.Contrib.
        /// </summary>
        public IEnumerable<Futbolista> GetAll()
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: GetAll<T>() genera automáticamente "SELECT * FROM Futbolistas"
            return connection.GetAll<Futbolista>();
        }

        /// <summary>
        /// Obtiene un futbolista por su código usando Get de Dapper.Contrib.
        /// </summary>
        public Futbolista? GetByCodigo(string codigo)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: Get<T>(id) genera automáticamente "SELECT * FROM Futbolistas WHERE Codigo = @id"
            return connection.Get<Futbolista>(codigo);
        }

        /// <summary>
        /// Obtiene futbolistas por código de equipo.
        /// NOTA: Este método requiere un filtro personalizado, por lo que usamos Dapper tradicional.
        /// Dapper.Contrib no soporta consultas con WHERE personalizados.
        /// </summary>
        public IEnumerable<Futbolista> GetByEquipoCodigo(string codigoEquipo)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper tradicional: necesario para filtros personalizados
            const string sql = "SELECT * FROM Futbolistas WHERE CodigoEquipo = @CodigoEquipo";
            return connection.Query<Futbolista>(sql, new { CodigoEquipo = codigoEquipo });
        }

        /// <summary>
        /// Obtiene futbolistas por nombre de equipo usando un JOIN.
        /// NOTA: Este método requiere un JOIN, por lo que usamos Dapper tradicional.
        /// Dapper.Contrib no soporta JOINs.
        /// </summary>
        public IEnumerable<Futbolista> GetByEquipoNombre(string nombreEquipo)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper tradicional: necesario para JOINs
            const string sql = @"
            SELECT F.* 
            FROM Futbolistas F 
            INNER JOIN Equipos E ON F.CodigoEquipo = E.Codigo 
            WHERE E.Nombre = @NombreEquipo";
            return connection.Query<Futbolista>(sql, new { NombreEquipo = nombreEquipo });
        }

        /// <summary>
        /// Inserta un nuevo futbolista usando Insert de Dapper.Contrib.
        /// </summary>
        public int Insert(Futbolista futbolista)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: Insert genera automáticamente el INSERT con todos los campos
            connection.Insert(futbolista);
            return 1;
        }

        /// <summary>
        /// Actualiza un futbolista existente usando Update de Dapper.Contrib.
        /// </summary>
        public int Update(Futbolista futbolista)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: Update genera automáticamente el UPDATE SET ... WHERE Codigo = @Codigo
            return connection.Update(futbolista) ? 1 : 0;
        }

        /// <summary>
        /// Elimina un futbolista por su código.
        /// </summary>
        public int Delete(string codigo)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: Delete requiere una entidad, no solo el ID
            var futbolista = new Futbolista { Codigo = codigo };
            return connection.Delete(futbolista) ? 1 : 0;
        }
    }
}
