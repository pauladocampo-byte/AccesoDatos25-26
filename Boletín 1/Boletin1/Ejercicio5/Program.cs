using System;
using System.IO;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string RUTA_DIRECTORIO = @"C:\Windows";
            var ficheros = Directory.EnumerateFileSystemEntries(RUTA_DIRECTORIO, "*");

            Console.WriteLine("Los ficheros que hay en {0} son:", RUTA_DIRECTORIO);
            foreach (string item in ficheros)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
