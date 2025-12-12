using System;
using System.IO;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;

            fichero = File.CreateText("CiclosMontecastelo.txt");

            fichero.WriteLine("Hola a todos!");

            fichero.Close();
        }
    }
}
