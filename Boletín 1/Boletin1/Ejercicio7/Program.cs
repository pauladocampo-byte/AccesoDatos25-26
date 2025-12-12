using System;
using System.IO;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            var ficheros = Directory.EnumerateFileSystemEntries(Directory.GetCurrentDirectory());
            Console.WriteLine("El contenido del directorio actual es: ");
            foreach (string item in ficheros)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
