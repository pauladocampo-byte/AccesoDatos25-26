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
        public FutbolistaService(IFutbolistaRepository futbolistaRepository)
        {
            _futbolistaRepository = futbolistaRepository;
        }

        public IEnumerable<Futbolista> GetFutbolistasByEquipoCodigo(string codigoEquipo)
        {
            return _futbolistaRepository.GetByEquipoCodigo(codigoEquipo);
        }

        public IEnumerable<Futbolista> GetFutbolistasByEquipoNombre(string nombreEquipo)
        {
            return _futbolistaRepository.GetByEquipoNombre(nombreEquipo);
        }

    }
}
