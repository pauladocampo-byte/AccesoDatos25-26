using System;
using System.IO;

//Programa con entrada explícita desde net 6

// Crear el directorio principal
string rutaDirectorio = @"C:\MiDirectorio";
Directory.CreateDirectory(rutaDirectorio); // Crea el directorio si no existe
Console.WriteLine($"Directorio principal: {rutaDirectorio}");

// Crear archivos dentro del directorio
string archivo1 = Path.Combine(rutaDirectorio, "archivo1.txt");
string archivo2 = Path.Combine(rutaDirectorio, "archivo2.txt");

File.WriteAllText(archivo1, "Contenido del archivo 1.");
File.WriteAllText(archivo2, "Contenido del archivo 2.");
Console.WriteLine("Archivos creados en el directorio.");

// Crear un segundo directorio para mover los archivos
string rutaOtroDirectorio = @"C:\OtroDirectorio";
Directory.CreateDirectory(rutaOtroDirectorio);
Console.WriteLine($"Segundo directorio: {rutaOtroDirectorio}");

// Mover los archivos al segundo directorio
string archivo1Destino = Path.Combine(rutaOtroDirectorio, "archivo1.txt");
string archivo2Destino = Path.Combine(rutaOtroDirectorio, "archivo2.txt");

File.Move(archivo1, archivo1Destino, overwrite: true);
File.Move(archivo2, archivo2Destino, overwrite: true);
Console.WriteLine("Archivos movidos al segundo directorio.");

// Listar el contenido de un directorio seleccionado
Console.WriteLine("\nContenido del directorio seleccionado:");
var archivos = Directory.GetFiles(rutaOtroDirectorio);

foreach (var archivo in archivos)
{
    var infoArchivo = new FileInfo(archivo);
    Console.WriteLine($"- {infoArchivo.Name} (Tamaño: {infoArchivo.Length} bytes)");
}

Console.WriteLine("\nOperaciones completadas. Presiona cualquier tecla para salir.");
Console.ReadKey();

