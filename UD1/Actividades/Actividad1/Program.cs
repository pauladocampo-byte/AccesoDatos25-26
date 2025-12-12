using System;
using System.IO;

namespace Actividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;

            Console.WriteLine("Actividad 1");
            Console.WriteLine("Leo las frases que escribes y las guardo en un fichero");

            StreamWriter fichero;

            fichero = File.CreateText("Log_Usuario.txt");

            do
            {
                frase = Console.ReadLine();
                if (frase.ToUpper() == "END")
                {
                    break;
                }
                fichero.WriteLine(frase);
            } while (frase.ToUpper() != "END");

            fichero.Close();
            Environment.Exit(0);
        }
    }
}
