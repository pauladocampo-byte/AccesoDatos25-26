using Actividad6.ClienteApi;
using Microsoft.Extensions.Configuration;

namespace Actividad6.Frontend
{
    internal static class Program
    {
        /// <summary>
        /// Configuración de la aplicación
        /// </summary>
        private static IConfiguration Configuration { get; }

        /// <summary>
        /// URL base de la API
        /// </summary>
        public static string ApiBaseUrl { get; }

        /// <summary>
        /// Cliente API compartido
        /// </summary>
        public static PanaderiaApiClient ApiClient { get; }

        static Program()
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            ApiBaseUrl = Configuration["ApiSettings:BaseUrl"] ?? "http://localhost:5000";
            ApiClient = new PanaderiaApiClient(ApiBaseUrl);
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
