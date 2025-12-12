using System;
using System.IO;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;

            Console.WriteLine("Leo las frases que escribes y las guardo en un fichero");

            StreamWriter fichero;

            fichero = File.CreateText("registroDeUsuario.txt");

            do
            {
                frase = Console.ReadLine();
                if (frase.ToUpper() == "fin")
                {
                    break;
                }
                fichero.WriteLine(frase);
            } while (frase.ToUpper() != "fin");

            fichero.Close();
            Environment.Exit(0);
        }
    }
}
