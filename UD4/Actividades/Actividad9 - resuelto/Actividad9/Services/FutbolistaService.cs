using Actividad9.DataAccess;
using Actividad9.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad9.Services
{
    public class FutbolistaService
    {
        private readonly IFutbolistaRepository _futbolistaRepository;
        private readonly IEquipoRepository _equipoRepository;
        public FutbolistaService(IFutbolistaRepository futbolistaRepository,IEquipoRepository equipoRepository)
        {
            _futbolistaRepository = futbolistaRepository;
            _equipoRepository = equipoRepository;
        }


        public IEnumerable<Futbolista> GetAllFutbolistas()
        {
            return _futbolistaRepository.GetAll();
        }

        public Futbolista? GetFutbolistaByCodigo(string codigo)
        {
            //if (string.IsNullOrWhiteSpace(codigo))
            //    throw new ArgumentException("El código del futbolista no puede estar vacío", nameof(codigo));

            return _futbolistaRepository.GetByCodigo(codigo);
        }

        public IEnumerable<Futbolista> GetFutbolistasByEquipoCodigo(string codigoEquipo)
        {
            //if (string.IsNullOrWhiteSpace(codigoEquipo))
            //    throw new ArgumentException("El código del equipo no puede estar vacío", nameof(codigoEquipo));

            return _futbolistaRepository.GetByEquipoCodigo(codigoEquipo);
        }

        public IEnumerable<Futbolista> GetFutbolistasByEquipoNombre(string nombreEquipo)
        {
            //if (string.IsNullOrWhiteSpace(nombreEquipo))
            //    throw new ArgumentException("El nombre del equipo no puede estar vacío", nameof(nombreEquipo));

            return _futbolistaRepository.GetByEquipoNombre(nombreEquipo);
        }

        public bool CreateFutbolista(Futbolista futbolista)
        {
            // Verificar que el equipo existe
            var equipo = _equipoRepository.GetByCodigo(futbolista.CodigoEquipo);
            if (equipo == null)
                throw new InvalidOperationException($"No existe un equipo con el código '{futbolista.CodigoEquipo}'");

            // Verificar si ya existe el futbolista
            var existente = _futbolistaRepository.GetByCodigo(futbolista.Codigo);
            if (existente != null)
                throw new InvalidOperationException($"Ya existe un futbolista con el código '{futbolista.Codigo}'");

            var result = _futbolistaRepository.Insert(futbolista);
            return result > 0;
        }

        public bool UpdateFutbolista(Futbolista futbolista)
        {
          
            // Verificar que el equipo existe
            var equipo = _equipoRepository.GetByCodigo(futbolista.CodigoEquipo);
            if (equipo == null)
                throw new InvalidOperationException($"No existe un equipo con el código '{futbolista.CodigoEquipo}'");

            var result = _futbolistaRepository.Update(futbolista);
            return result > 0;
        }

        public bool DeleteFutbolista(string codigo)
        {
            var result = _futbolistaRepository.Delete(codigo);
            return result > 0;
        }
    }
}
