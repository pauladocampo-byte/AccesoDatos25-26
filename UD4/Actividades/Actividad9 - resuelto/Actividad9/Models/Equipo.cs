using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Actividad9.Models
{
    /// <summary>
    /// Representa un equipo en la base de datos.
    /// [Table] indica el nombre de la tabla en la BD.
    /// </summary>
    [Table("Equipos")]
    public class Equipo
    {
        /// <summary>
        /// Clave primaria explícita (no autoincremental).
        /// Usamos [ExplicitKey] porque nosotros asignamos el valor.
        /// </summary>
        [ExplicitKey]
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
