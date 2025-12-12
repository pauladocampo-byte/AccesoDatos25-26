using System;
using System.IO;

namespace Actividad4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Mostramos las 3 primeras lineas del fichero de la Actividad 1");

            using (StreamReader fichero = new StreamReader("../../../../Actividad1/bin/Debug/netcoreapp3.1/Log_Usuario.txt"))
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(fichero.ReadLine());
                }
            }

            Console.ReadKey();
        }
    }
}
