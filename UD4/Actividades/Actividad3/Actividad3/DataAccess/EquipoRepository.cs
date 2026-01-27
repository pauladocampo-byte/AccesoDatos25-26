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

    }
}
