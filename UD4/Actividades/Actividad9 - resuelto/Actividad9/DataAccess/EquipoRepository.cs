using Actividad9.Data;
using Actividad9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Data;

namespace Actividad9.DataAccess
{
    /// <summary>
    /// Repositorio de Equipos usando Dapper.Contrib para operaciones CRUD básicas.
    /// </summary>
    public class EquipoRepository : IEquipoRepository
    {

        private readonly IDbConnectionFactory _connectionFactory;
        public EquipoRepository(IDbConnectionFactory connectionFactory) 
        {
            _connectionFactory = connectionFactory;
        }

        /// <summary>
        /// Obtiene todos los equipos usando GetAll de Dapper.Contrib.
        /// Ya no necesitamos escribir SQL para esta operación.
        /// </summary>
        public IEnumerable<Equipo> GetAll()
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: GetAll<T>() genera automáticamente "SELECT * FROM Equipos"
            return connection.GetAll<Equipo>();
        }

        /// <summary>
        /// Obtiene un equipo por su código usando Get de Dapper.Contrib.
        /// </summary>
        public Equipo? GetByCodigo(string codigo)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: Get<T>(id) genera automáticamente "SELECT * FROM Equipos WHERE Codigo = @id"
            return connection.Get<Equipo>(codigo);
        }

        /// <summary>
        /// Inserta un nuevo equipo usando Insert de Dapper.Contrib.
        /// </summary>
        public int Insert(Equipo equipo)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: Insert genera automáticamente el INSERT con todos los campos
            // Devuelve el número de filas afectadas (para ExplicitKey devuelve la clave como long)
            connection.Insert(equipo);
            return 1; // Insert con ExplicitKey no devuelve el número de filas, así que retornamos 1
        }

        /// <summary>
        /// Actualiza un equipo existente usando Update de Dapper.Contrib.
        /// </summary>
        public int Update(Equipo equipo)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: Update genera automáticamente el UPDATE SET ... WHERE Codigo = @Codigo
            return connection.Update(equipo) ? 1 : 0;
        }

        /// <summary>
        /// Elimina un equipo por su código.
        /// Usamos Delete de Dapper.Contrib pasando una entidad con solo la clave.
        /// </summary>
        public int Delete(string codigo)
        {
            using var connection = _connectionFactory.CreateConnection();
            // Dapper.Contrib: Delete requiere una entidad, no solo el ID
            // Creamos una entidad con solo la clave primaria
            var equipo = new Equipo { Codigo = codigo };
            return connection.Delete(equipo) ? 1 : 0;
        }

    }
}
