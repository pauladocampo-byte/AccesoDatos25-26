using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Data
{
    public interface IDbConnectionFactory
    {
        /// <summary>
        /// Crea una nueva conexión a la base de datos.
        /// </summary>
        IDbConnection CreateConnection();
    }
}
