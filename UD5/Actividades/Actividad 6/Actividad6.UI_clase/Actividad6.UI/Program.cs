using Actividad6.ClienteApi;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Actividad6.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cargar configuración
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var apiBaseUrl = configuration["ApiSettings:BaseUrl"] ?? "http://localhost:5000";

            // Crear el cliente API
            using var apiClient = new PanaderiaApiClient(apiBaseUrl);

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(apiClient));
        }
    }
}