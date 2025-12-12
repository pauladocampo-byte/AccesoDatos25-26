using System;
using System.IO;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, resta;
            const string RUTA_FICHERO = "resultados/restas.txt";
            string resultado;

            Console.WriteLine("Escribe el primer numero entero:");
            int.TryParse(Console.ReadLine(), out numero1);
            Console.WriteLine("Escribe el segundo numero entero:");
            int.TryParse(Console.ReadLine(), out numero2);
            resta = numero1 - numero2;
            Console.Write("La resta es: ");
            resultado = numero1 + " - " + numero2 + " = " + resta;
            Console.WriteLine(resultado);

            if (File.Exists(RUTA_FICHERO))
            {
                StreamWriter fichero;

                fichero = File.AppendText(RUTA_FICHERO);
                fichero.WriteLine(resultado);
                fichero.Close();
            }
            Console.ReadKey();
        }
    }
}
