using System;
using System.IO;

namespace Actividad7
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            string frase;
            ConsoleKeyInfo tecla;

            Console.WriteLine("Actividad 7");
            Console.WriteLine("Leo las frases que escribes y las guardo en un fichero");

            fichero = File.AppendText("Log.txt");

            do
            {
                frase = Console.ReadLine();
                fichero.WriteLine(frase);
                tecla = Console.ReadKey();
                if (tecla.Key == ConsoleKey.Enter)
                {
                    break;
                }
            } while (frase.ToUpper() != "END");

            fichero.Close();
            Environment.Exit(0);
        }
    }
}
