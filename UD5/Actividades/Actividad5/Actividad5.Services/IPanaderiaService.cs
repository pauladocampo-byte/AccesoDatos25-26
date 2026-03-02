using Actividad5.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Services
{
    public interface IPanaderiaService
    {
        List<Panaderia> ObtenerTodas();
        Panaderia? ObtenerPorId(int id);
        void Crear(Panaderia panaderia);
        void Actualizar(Panaderia panaderia);
        void Eliminar(int id);
    }
}
