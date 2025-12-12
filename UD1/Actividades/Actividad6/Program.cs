using System;
using System.IO;

namespace Actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreFichero;

            //Pedimos el nombre del fichero
            Console.WriteLine("Dime el fichero que quieres analizar");
            nombreFichero = Console.ReadLine();

            using (StreamReader fichero = new StreamReader(nombreFichero))
            {
                string linea = fichero.ReadLine();
                while (linea != null)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine(linea);
                        linea = fichero.ReadLine();
                    }
                    Console.ReadKey();
                }
                fichero.Close();
            }

            Console.ReadKey();
        }
    }
}
