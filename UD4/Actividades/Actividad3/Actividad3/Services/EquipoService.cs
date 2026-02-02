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

        public (bool success,string message)  CreateEquipo(Models.Equipo equipo)
        {
            var existe = _equipoRepository.GetEquipoByCodigo(equipo.Codigo);
            if (existe != null)
            {
                return (false, "El equipo con ese código ya existe");
            }
            var result = _equipoRepository.Insert(equipo);

            return result>0
              ? (true, "Equipo creado exitosamente")
              : (false, "Error al crear el equipo en la base de datos");
        }

        public bool DeleteEquipo(string codigo)
        {
            var existe = _equipoRepository.GetEquipoByCodigo(codigo);
            if (existe == null)
            {
                return false;
            }

            //Comprobamos si el equipo tiene jugadores asociados
            var futbolistas =  _futbolistaRepository.GetByEquipoCodigo(codigo);

            if (futbolistas.Any())
            {
                throw new InvalidOperationException("No se puede eliminar el equipo porque tiene futbolistas asociados.");
            }
     
            var result = _equipoRepository.Delete(codigo);
            return result > 0;
        }

        public bool UpdateEquipo(Equipo equipo)
        {
            var result = _equipoRepository.Update(equipo);
            return result > 0;
        }
    }
}
