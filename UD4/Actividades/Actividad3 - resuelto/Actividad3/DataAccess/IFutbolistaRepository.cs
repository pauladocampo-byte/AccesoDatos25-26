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
        /// Obtiene todos los futbolistas.
        /// </summary>
        IEnumerable<Futbolista> GetAll();

        /// <summary>
        /// Obtiene un futbolista por su código.
        /// </summary>
        Futbolista? GetByCodigo(string codigo);

        /// <summary>
        /// Obtiene todos los futbolistas de un equipo.
        /// </summary>
        IEnumerable<Futbolista> GetByEquipoCodigo(string codigoEquipo);

        /// <summary>
        /// Obtiene todos los futbolistas de un equipo por nombre del equipo.
        /// </summary>
        IEnumerable<Futbolista> GetByEquipoNombre(string nombreEquipo);

        /// <summary>
        /// Inserta un nuevo futbolista.
        /// </summary>
        int Insert(Futbolista futbolista);

        /// <summary>
        /// Actualiza un futbolista existente.
        /// </summary>
        int Update(Futbolista futbolista);

        /// <summary>
        /// Elimina un futbolista por su código.
        /// </summary>
        int Delete(string codigo);
    }
}
