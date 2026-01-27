using Actividad3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.DataAccess
{
    public  interface IEquipoRepository
    {
        IEnumerable<Equipo> GetAll();
    }
}
