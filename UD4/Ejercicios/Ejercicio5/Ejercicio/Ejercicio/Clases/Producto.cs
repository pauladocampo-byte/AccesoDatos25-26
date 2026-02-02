using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio.Clases
{
    public class Producto
    {
        int codigo;
        string nombre;
        Single precio;
        int codigo_fabricante;

        public Producto()
        {
        }

        public Producto(int codigo, string nombre, Single precio, int codigo_fabricante)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.precio = precio;
            this.codigo_fabricante = codigo_fabricante;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Single Precio { get => precio; set => precio = value; }
        public int Codigo_fabricante { get => codigo_fabricante; set => codigo_fabricante = value; }

        public override string ToString()
        {
            return this.Nombre + " " + this.Precio;
        }
    }
}
