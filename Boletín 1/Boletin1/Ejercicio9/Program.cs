using System;
using System.IO;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory(@"D:\HOME\d1");
            if (File.Exists("f11.txt"))
            {
                File.Move("f11.txt", "f12.txt");
            }
            Directory.SetCurrentDirectory(@"..\d2");
            if (File.Exists("f21.txt"))
            {
                File.Move("f21.txt", @"..\d1\f21.txt");
            }
            Directory.SetCurrentDirectory(@"..");
            Directory.Delete("d2");
            Console.WriteLine("Se han realizado todas las operaciones");
            Console.ReadKey();
        }
    }
}
