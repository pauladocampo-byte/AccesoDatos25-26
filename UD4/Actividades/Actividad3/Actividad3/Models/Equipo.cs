using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Models
{
    public class Equipo
    {
        public string Codigo { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string? Pais { get; set; }
        public int Goles { get; set; }
        public int Puntos { get; set; }
        public string? PJ { get; set; }
        public int PG { get; set; }
        public int PE { get; set; }
        public int PP { get; set; }
        public string? Estadio { get; set; }
        public string? Ciudad { get; set; }

        // Constructor sin parámetros requerido por Dapper
        public Equipo() { }

        public Equipo(string codigo, string nombre, string? pais, string? estadio, string? ciudad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Pais = pais;
            Estadio = estadio;
            Ciudad = ciudad;
        }

        public override string ToString() => Nombre;
    }

}
