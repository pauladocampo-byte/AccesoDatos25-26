using Actividad5.Data;
using Actividad5.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Actividad5.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //configuro el servicio
            var services = ConfigureServices();
            //Creamos el provedor de servicio
            var serviceProvider = services.BuildServiceProvider();

            //Ejecutamos la apliación con inyección de dependencias
            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<PanaderiaContext>(options => options.UseSqlServer(connectionString));

            services.AddTransient<Form1>();

            services.AddScoped<IProductoService, ProductoService>();    
            services.AddScoped<IPanaderiaService, PanaderiaService>();
            services.AddScoped<IPanaderiaProductoService, PanaderiaProductoService>();

            return services;
        }
    }
}