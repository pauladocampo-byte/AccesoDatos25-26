using Actividad6.ClienteApi.Dto;
using System.Net.Http.Json;
using System.Text.Json;

namespace Actividad6.ClienteApi
{
    public class PanaderiaApiClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly bool _disposeHttpClient;


        public PanaderiaApiClient(HttpClient httpClient, bool disposeHttpClient = false)
        {
            _httpClient = httpClient;
            _disposeHttpClient = disposeHttpClient;
        }

        public PanaderiaApiClient(string baseAddress)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseAddress) };
            _disposeHttpClient = true;
        }

        public async Task<List<PanaderiaDto>> ObtenerPanaderiasAsync()
        {
            var response = await _httpClient.GetAsync("api/panaderia");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<PanaderiaDto>>() ?? new List<PanaderiaDto>();
        }

        /// <summary>
        /// Obtiene todos los productos
        /// </summary>
        public async Task<List<ProductoDto>> ObtenerProductosAsync()
        {
            var response = await _httpClient.GetAsync("api/producto");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<ProductoDto>>() ?? new List<ProductoDto>();
        }

        public async Task<List<PanaderiaProductoDto>> ObtenerRelacionesAsync()
        {
            var response = await _httpClient.GetAsync("api/panaderiasproductos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<PanaderiaProductoDto>>() ?? new List<PanaderiaProductoDto>();
        }

        public async Task<ProductoDto> CrearProductoAsync(ProductoDto producto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/producto", producto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ProductoDto>()
                ?? throw new InvalidOperationException("Error al crear el producto");
        }

        /// <summary>
        /// Crea una nueva panadería
        /// </summary>
        public async Task<PanaderiaDto> CrearPanaderiaAsync(PanaderiaDto panaderia)
        {
            var response = await _httpClient.PostAsJsonAsync("api/panaderia", panaderia);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PanaderiaDto>()
                ?? throw new InvalidOperationException("Error al crear la panadería");
        }

        /// <summary>
        /// Crea una nueva relación panadería-producto
        /// </summary>
        public async Task<PanaderiaProductoDto> CrearRelacionAsync(PanaderiaProductoDto relacion)
        {
            var response = await _httpClient.PostAsJsonAsync("api/panaderiasproductos", relacion);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PanaderiaProductoDto>()
                ?? throw new InvalidOperationException("Error al crear la relación");
        }


        void IDisposable.Dispose()
        {
            if (_disposeHttpClient)
            {
                _httpClient.Dispose();
            }   
        }
    }
}
