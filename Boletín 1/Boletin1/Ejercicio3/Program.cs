using System;
using System.IO;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string rutaFichero, fraseABuscar;

            Console.WriteLine("Escribe la ruta del fichero de texto:");
            rutaFichero = Console.ReadLine();
            Console.WriteLine("Escribe la frase a buscar:");
            fraseABuscar = Console.ReadLine();

            if (File.Exists(rutaFichero))
            {
                StreamReader fichero;
                string linea = "";
                int numeroLinea = 1;

                fichero = File.OpenText(rutaFichero);

                while (linea != null)
                {
                    linea = fichero.ReadLine();
                    if (linea != null && linea.Contains(fraseABuscar))
                    {
                        Console.WriteLine(numeroLinea.ToString() + ". " + linea);
                    }
                    numeroLinea++;
                }
            }
            Console.ReadKey();
        }
    }
}
