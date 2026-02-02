using Actividad3.DataAccess;
using Actividad3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Services
{
    public class EquipoService
    {
        private readonly IEquipoRepository _equipoRepository;
        private readonly IFutbolistaRepository _futbolistaRepository;

        public EquipoService(IEquipoRepository equipoRepository, IFutbolistaRepository futbolistaRepository)
        {
            _equipoRepository = equipoRepository;
            _futbolistaRepository = futbolistaRepository;
        }

        public IEnumerable<Models.Equipo> GetAllEquipos()
        {
            return _equipoRepository.GetAll();
        }

        public Equipo? GetEquipoByCodigo(string codigo)
        {
            return _equipoRepository.GetByCodigo(codigo);
        }

        public bool CreateEquipo(Equipo equipo)
        {
            // Verificar si ya existe
            var existente = _equipoRepository.GetByCodigo(equipo.Codigo);
            if (existente != null)
                throw new InvalidOperationException($"Ya existe un equipo con el código '{equipo.Codigo}'");

            var result = _equipoRepository.Insert(equipo);
            return result > 0;
        }

        public bool UpdateEquipo(Equipo equipo)
        {
            var result = _equipoRepository.Update(equipo);
            return result > 0;
        }

        public bool DeleteEquipo(string codigo)
        {
            // Verificar si tiene futbolistas asociados
            var futbolistas = _futbolistaRepository.GetByEquipoCodigo(codigo);
            if (futbolistas.Any())
            {
                throw new InvalidOperationException(
                    $"No se puede eliminar el equipo porque tiene {futbolistas.Count()} futbolistas asociados. " +
                    "Elimine primero los futbolistas.");
            }

            var result = _equipoRepository.Delete(codigo);
            return result > 0;
        }
    }
}
