using System;
using System.IO;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DIRECTORIO_RAIZ = @"D:\home\";

            Directory.CreateDirectory(DIRECTORIO_RAIZ);
            Directory.SetCurrentDirectory(DIRECTORIO_RAIZ);
            Directory.CreateDirectory("usr1");
            Directory.CreateDirectory("usr2");
            Directory.SetCurrentDirectory("usr1");
            File.CreateText("f1");
            Directory.SetCurrentDirectory(@"..\usr2");
            Directory.CreateDirectory("d1");
            Directory.CreateDirectory("d2");
            Directory.SetCurrentDirectory("d1");
            File.CreateText("f2");
            Directory.SetCurrentDirectory(@"..\d2");
            File.CreateText("f3");
            File.CreateText("f4");
            Directory.CreateDirectory("d3");
            Console.WriteLine("Los directorios y ficheros han sido creados correctamente");
            Console.ReadKey();
        }
    }
}
