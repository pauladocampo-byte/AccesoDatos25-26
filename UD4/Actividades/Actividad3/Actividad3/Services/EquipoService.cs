using Actividad3.DataAccess;
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

        public EquipoService(IEquipoRepository equipoRepository)
        {
            _equipoRepository = equipoRepository;
        }

        public IEnumerable<Models.Equipo> GetAllEquipos()
        {
            return _equipoRepository.GetAll();
        }
    }
}
