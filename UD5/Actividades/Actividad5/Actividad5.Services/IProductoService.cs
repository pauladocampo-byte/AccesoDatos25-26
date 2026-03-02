using Actividad5.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Services
{
    public  interface IProductoService
    {
        List<Producto> ObtenerTodos();
        Producto? ObtenerPorId(int id);
        void Crear(Producto producto);
        void Actualizar(Producto producto);
        void Eliminar(int id);
    }
}
