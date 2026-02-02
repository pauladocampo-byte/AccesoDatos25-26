using Actividad3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.DataAccess
{
    public interface IFutbolistaRepository
    {

        /// <summary>
        /// Obtiene todos los futbolistas de un equipo.
        /// </summary>
        IEnumerable<Futbolista> GetByEquipoCodigo(string codigoEquipo);

        /// <summary>
        /// Obtiene todos los futbolistas de un equipo por nombre del equipo.
        /// </summary>
        IEnumerable<Futbolista> GetByEquipoNombre(string nombreEquipo);

        int Insert(Futbolista futbolista);

        Futbolista GetByCodigo(string codigo);

        int Delete(string codigo);

        int Update(Futbolista futbolista);
    }
}
