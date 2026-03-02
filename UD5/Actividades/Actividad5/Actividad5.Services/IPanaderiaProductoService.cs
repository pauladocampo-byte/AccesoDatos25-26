using Actividad5.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Services
{
    public interface IPanaderiaProductoService
    {
        List<PanaderiaProducto> ObtenerTodas();
        List<PanaderiaProducto> ObtenerPorPanaderia(int panaderiaId);
        List<PanaderiaProducto> ObtenerPorProducto(int productoId);
        PanaderiaProducto? ObtenerPorIds(int panaderiaId, int productoId);
        void Crear(PanaderiaProducto relacion);
        void Actualizar(PanaderiaProducto relacion);
        void Eliminar(int panaderiaId, int productoId);
        bool Existe(int panaderiaId, int productoId);
    }
}
