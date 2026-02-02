using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace Actividad9.Models
{
    /// <summary>
    /// Representa un futbolista en la base de datos.
    /// [Table] indica el nombre de la tabla en la BD.
    /// </summary>
    [Table("Futbolistas")]
    public class Futbolista
    {
        /// <summary>
        /// Clave primaria explícita (no autoincremental).
        /// Usamos [ExplicitKey] porque nosotros asignamos el valor.
        /// </summary>
        [ExplicitKey]
        public string Codigo { get; set; } = string.Empty;
        
        public string Nombre { get; set; } = string.Empty;
        public string CodigoEquipo { get; set; } = string.Empty;
        public string? Posicion { get; set; }
        public int Edad { get; set; }
        public int Goles { get; set; }
        public int TA { get; set; }  // Tarjetas Amarillas
        public int TR { get; set; }  // Tarjetas Rojas
        public int Minutos { get; set; }
        public string? PrecioMercado { get; set; }
        public int Dorsal { get; set; }
        public int Peso { get; set; }

        // Constructor sin parámetros requerido por Dapper
        public Futbolista() { }

        public Futbolista(string codigo, string nombre, string codigoEquipo, string? posicion, int edad, int dorsal)
        {
            Codigo = codigo;
            Nombre = nombre;
            CodigoEquipo = codigoEquipo;
            Posicion = posicion;
            Edad = edad;
            Dorsal = dorsal;
        }

        public override string ToString() => Nombre;
    }
}
