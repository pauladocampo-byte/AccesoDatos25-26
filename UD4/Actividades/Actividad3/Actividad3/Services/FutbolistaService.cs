using Actividad3.DataAccess;
using Actividad3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Services
{
    public class FutbolistaService
    {
        private readonly IFutbolistaRepository _futbolistaRepository;
        private readonly IEquipoRepository _equipoRepository;
        public FutbolistaService(IFutbolistaRepository futbolistaRepository, IEquipoRepository equipoRepository)
        {
            _futbolistaRepository = futbolistaRepository;
            _equipoRepository = equipoRepository;
        }

        public IEnumerable<Futbolista> GetFutbolistasByEquipoCodigo(string codigoEquipo)
        {
            return _futbolistaRepository.GetByEquipoCodigo(codigoEquipo);
        }

        public IEnumerable<Futbolista> GetFutbolistasByEquipoNombre(string nombreEquipo)
        {
            return _futbolistaRepository.GetByEquipoNombre(nombreEquipo);
        }

        public bool CrearFutbolista(Futbolista futbolista)
        {
            //verificamos que el equipo exista
            var equipo =  _equipoRepository.GetEquipoByCodigo(futbolista.CodigoEquipo);
            if (equipo == null)
                throw new InvalidOperationException($"No existe un equipo con el código '{futbolista.CodigoEquipo}'");

            //Verificamos que no exista un futbolista con el mismo codigo
            var futbolistaExistente = _futbolistaRepository.GetByCodigo(futbolista.Codigo);
            if (futbolistaExistente != null)
                throw new InvalidOperationException($"Ya existe un futbolista con el código '{futbolista.Codigo}'");

            var result = _futbolistaRepository.Insert(futbolista);
            return result > 0;
        }

        public bool DeleteFutbolista(string codigo)
        {
            var futbolistaExistente = _futbolistaRepository.GetByCodigo(codigo);
            if (futbolistaExistente == null)
                return false;
            var result = (_futbolistaRepository as FutbolistaRepository)?.Delete(codigo);
            return result.HasValue && result.Value > 0;
        }

        public bool UpdateFutbolista(Futbolista futbolista)
        {

            // Verificar que el equipo existe
            var equipo = _equipoRepository.GetEquipoByCodigo(futbolista.CodigoEquipo);
            if (equipo == null)
                throw new InvalidOperationException($"No existe un equipo con el código '{futbolista.CodigoEquipo}'");

            var result = _futbolistaRepository.Update(futbolista);
            return result > 0;
        }

    }
}
