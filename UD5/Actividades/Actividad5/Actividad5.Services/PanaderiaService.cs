using Actividad5.Core;
using Actividad5.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad5.Services
{
    public class PanaderiaService : IPanaderiaService
    {
        private readonly PanaderiaContext _context;

        public PanaderiaService(PanaderiaContext context)
        {
            _context = context;
        }

        public List<Panaderia> ObtenerTodas()
        {
            return _context.Panaderias.ToList();
        }

        public Panaderia? ObtenerPorId(int id)
        {
            return _context.Panaderias.Find(id);
        }

        public void Crear(Panaderia panaderia)
        {
            _context.Panaderias.Add(panaderia);
            _context.SaveChanges();
        }

        public void Actualizar(Panaderia panaderia)
        {
            _context.Panaderias.Update(panaderia);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var panaderia = _context.Panaderias.Find(id);
            if (panaderia != null)
            {
                _context.Panaderias.Remove(panaderia);
                _context.SaveChanges();
            }
        }
    }
}
