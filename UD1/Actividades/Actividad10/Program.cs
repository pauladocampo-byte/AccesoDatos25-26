using System;
using System.IO;

namespace Actividad10
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo directorio = new DirectoryInfo(@"C:\MiDirectorio");

            //Hacemos las operaciones

            if (directorio.Exists)
            {
                Console.WriteLine("El directorio existe");
            }
            else
            {
                Console.WriteLine("El directorio no existe");
                Console.WriteLine("Creando...");
                directorio.Create();
            }

            if (directorio.Exists)
            {
                directorio.Delete();
            }

            Console.ReadKey();
        }
    }
}
