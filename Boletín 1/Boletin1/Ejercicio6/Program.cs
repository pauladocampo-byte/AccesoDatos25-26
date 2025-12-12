using System;
using System.IO;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string directorioActual = Directory.GetCurrentDirectory();
            Console.WriteLine("El directorio actual es: {0}", directorioActual);
            Console.ReadKey();
        }
    }
}
