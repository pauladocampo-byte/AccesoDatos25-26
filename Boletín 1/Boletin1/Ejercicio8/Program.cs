using System;
using System.IO;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DIRECTORIO_RAIZ = @"D:\HOME";

            Directory.CreateDirectory(DIRECTORIO_RAIZ);
            Directory.SetCurrentDirectory(DIRECTORIO_RAIZ);
            Directory.CreateDirectory("d1");
            Directory.CreateDirectory("d2");
            Directory.SetCurrentDirectory("d1");
            File.CreateText("f11.txt");
            Directory.SetCurrentDirectory(@"..\d2");
            File.CreateText("f21.txt");
            Console.WriteLine("Los directorios y ficheros han sido creados correctamente");
            Console.ReadKey();
        }
    }
}
