using System;
using System.IO;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta;
            Console.WriteLine("Introduce la ruta de un fichero o directorio");
            ruta = Console.ReadLine();

            FileInfo detalles = new FileInfo(ruta);
            Console.WriteLine("Nombre: " + detalles.Name);
            Console.WriteLine("Ruta: " + detalles.FullName);
            Console.WriteLine("Tamaño: " + detalles.Length);

            FileAttributes attr = File.GetAttributes(ruta);
            if ((attr & FileAttributes.Directory) == FileAttributes.Directory) Console.WriteLine("Tipo: Directorio");
            else Console.WriteLine("Tipo: Fichero");

            Console.WriteLine("Ultima modificacion: " + detalles.LastWriteTime);
            Console.WriteLine("Es de sólo lectura: " + detalles.IsReadOnly);

            Console.ReadKey();
        }
    }
}
