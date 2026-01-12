using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using Actividad6.DataAccess;
using Actividad6.Services;

namespace Actividad6
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Crear el host con inyección de dependencias
            var host = CreateHostBuilder().Build();

            // Ejecutar la aplicación con inyección de dependencias
            using (var serviceScope = host.Services.CreateScope())
            {
                var form1 = serviceScope.ServiceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory())
                          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    // Registrar la configuración
                    services.AddSingleton<IConfiguration>(context.Configuration);
                    
                    // Registrar el repositorio de acceso a datos
                    services.AddScoped<IAlumnoRepository, AlumnoRepository>();
                    
                    // Registrar el servicio de lógica de negocio
                    services.AddScoped<IAlumnoService, AlumnoService>();
                    
                    // Registrar el formulario
                    services.AddTransient<Form1>();
                });
    }
}