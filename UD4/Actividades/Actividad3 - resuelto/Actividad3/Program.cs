using System.DirectoryServices;
using Actividad3.Data;
using Actividad3.DataAccess;
using Actividad3.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Actividad3
{


    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; } = null!;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();
            ConfigureServices(services);

            ServiceProvider = services.BuildServiceProvider();

            //// Obtener el formulario principal desde el contenedor DI
            var mainForm = ServiceProvider.GetRequiredService<Form1>();

            Application.Run(mainForm);

        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Aquí puedes registrar tus servicios para la inyección de dependencias
            // services.AddTransient<ITuServicio, TuServicio>();
            //Configuration desde Appsettings.json
            var configuration = new ConfigurationBuilder()
             .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
             .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
             .Build();


            //Inyeccion de ConnectionFactory pasandole la cadena de conexion
            services.AddSingleton<IDbConnectionFactory>(sp =>
                new Actividad3.Data.SqlConnectionFactory(
                    configuration.GetConnectionString("DefaultConnection")
                )
            );


            //services.AddSingleton<IDbConnectionFactory>(sp =>
            //  new Actividad3.Data.PostgresConnectionFactory(
            //      configuration.GetConnectionString("DefaultConnection")
            //  )
            //);

            //Inyeccion de DataAccess
            services.AddTransient<IEquipoRepository, EquipoRepository>();
            services.AddTransient<IFutbolistaRepository, FutbolistaRepository>();

            //Inyeccion de Services
            services.AddTransient<EquipoService>();
            services.AddTransient<FutbolistaService>();

            //Inyectamos la configuracion
            services.AddSingleton<IConfiguration>(configuration);

            //Inyeccion del Form1
            services.AddTransient<Form1>();

        }
    }
}