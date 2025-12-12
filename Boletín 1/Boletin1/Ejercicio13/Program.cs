using System;
using System.IO;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            const string RUTA = @"D:\HOME";

            var ficheros = Directory.GetFileSystemEntries(RUTA);

            foreach (string item in ficheros)
            {
                FileInfo detalles = new FileInfo(item);
                // Obtengo los atributos para un fichero o directorio
                FileAttributes attr = File.GetAttributes(item);

                //Detecto si es un directorio o un fichero
                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                {
                    Console.WriteLine("Tipo: Directorio");
                    Console.WriteLine("Nombre: " + detalles.Name);
                }
                else
                {
                    Console.WriteLine("Tipo: Fichero");
                    Console.WriteLine("Nombre: " + detalles.Name);
                    Console.WriteLine("Tamaño: " + detalles.Length);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
