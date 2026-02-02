using Actividad9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad9.DataAccess
{
    public  interface IEquipoRepository
    {
        /// <summary>
        /// Obtiene todos los equipos.
        /// </summary>
        IEnumerable<Equipo> GetAll();
        /// <summary>
        /// Obtiene un equipo por su código.
        /// </summary>
        Equipo? GetByCodigo(string codigo);

        /// <summary>
        /// Inserta un nuevo equipo.
        /// </summary>
        int Insert(Equipo equipo);

        /// <summary>
        /// Actualiza un equipo existente.
        /// </summary>
        int Update(Equipo equipo);

        /// <summary>
        /// Elimina un equipo por su código.
        /// </summary>
        int Delete(string codigo);
    }
}
