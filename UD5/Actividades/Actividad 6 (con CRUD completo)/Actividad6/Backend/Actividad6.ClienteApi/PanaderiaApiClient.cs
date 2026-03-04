using Actividad6.ClienteApi.Models;
using System.Net.Http.Json;

namespace Actividad6.ClienteApi
{
    /// <summary>
    /// Cliente HTTP para interactuar con la API de Panaderías
    /// </summary>
    public class PanaderiaApiClient : IDisposable
    {
        private readonly HttpClient _httpClient;
        private readonly bool _disposeHttpClient;

        /// <summary>
        /// Crea una nueva instancia del cliente API
        /// </summary>
        /// <param name="baseUrl">URL base de la API (ejemplo: http://localhost:5000)</param>
        public PanaderiaApiClient(string baseUrl)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
            _disposeHttpClient = true;
        }

        /// <summary>
        /// Crea una nueva instancia del cliente API con un HttpClient existente
        /// </summary>
        /// <param name="httpClient">HttpClient configurado</param>
        public PanaderiaApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _disposeHttpClient = false;
        }

        #region Panaderías

        /// <summary>
        /// Obtiene todas las panaderías
        /// </summary>
        public async Task<List<PanaderiaDto>> ObtenerPanaderiasAsync()
        {
            var response = await _httpClient.GetAsync("api/panaderias");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<PanaderiaDto>>() ?? new List<PanaderiaDto>();
        }

        /// <summary>
        /// Obtiene una panadería por su ID
        /// </summary>
        public async Task<PanaderiaDto?> ObtenerPanaderiaPorIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/panaderias/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PanaderiaDto>();
        }

        /// <summary>
        /// Crea una nueva panadería
        /// </summary>
        public async Task<PanaderiaDto> CrearPanaderiaAsync(PanaderiaDto panaderia)
        {
            var response = await _httpClient.PostAsJsonAsync("api/panaderias", panaderia);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PanaderiaDto>() 
                ?? throw new InvalidOperationException("Error al crear la panadería");
        }

        /// <summary>
        /// Actualiza una panadería existente
        /// </summary>
        public async Task<PanaderiaDto?> ActualizarPanaderiaAsync(int id, PanaderiaDto panaderia)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/panaderias/{id}", panaderia);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PanaderiaDto>();
        }

        /// <summary>
        /// Elimina una panadería
        /// </summary>
        public async Task<bool> EliminarPanaderiaAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/panaderias/{id}");
            return response.IsSuccessStatusCode;
        }

        #endregion

        #region Productos

        /// <summary>
        /// Obtiene todos los productos
        /// </summary>
        public async Task<List<ProductoDto>> ObtenerProductosAsync()
        {
            var response = await _httpClient.GetAsync("api/productos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<ProductoDto>>() ?? new List<ProductoDto>();
        }

        /// <summary>
        /// Obtiene un producto por su ID
        /// </summary>
        public async Task<ProductoDto?> ObtenerProductoPorIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"api/productos/{id}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ProductoDto>();
        }

        /// <summary>
        /// Crea un nuevo producto
        /// </summary>
        public async Task<ProductoDto> CrearProductoAsync(ProductoDto producto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/productos", producto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ProductoDto>() 
                ?? throw new InvalidOperationException("Error al crear el producto");
        }

        /// <summary>
        /// Actualiza un producto existente
        /// </summary>
        public async Task<ProductoDto?> ActualizarProductoAsync(int id, ProductoDto producto)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/productos/{id}", producto);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<ProductoDto>();
        }

        /// <summary>
        /// Elimina un producto
        /// </summary>
        public async Task<bool> EliminarProductoAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/productos/{id}");
            return response.IsSuccessStatusCode;
        }

        #endregion

        #region Panaderías-Productos

        /// <summary>
        /// Obtiene todas las relaciones panadería-producto
        /// </summary>
        public async Task<List<PanaderiaProductoDto>> ObtenerRelacionesAsync()
        {
            var response = await _httpClient.GetAsync("api/panaderiasproductos");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<PanaderiaProductoDto>>() ?? new List<PanaderiaProductoDto>();
        }

        /// <summary>
        /// Obtiene una relación específica
        /// </summary>
        public async Task<PanaderiaProductoDto?> ObtenerRelacionAsync(int panaderiaId, int productoId)
        {
            var response = await _httpClient.GetAsync($"api/panaderiasproductos/{panaderiaId}/{productoId}");
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PanaderiaProductoDto>();
        }

        /// <summary>
        /// Crea una nueva relación panadería-producto
        /// </summary>
        public async Task<PanaderiaProductoDto> CrearRelacionAsync(PanaderiaProductoCreateDto relacion)
        {
            var response = await _httpClient.PostAsJsonAsync("api/panaderiasproductos", relacion);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PanaderiaProductoDto>() 
                ?? throw new InvalidOperationException("Error al crear la relación");
        }

        /// <summary>
        /// Actualiza una relación existente
        /// </summary>
        public async Task<PanaderiaProductoDto?> ActualizarRelacionAsync(int panaderiaId, int productoId, PanaderiaProductoUpdateDto relacion)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/panaderiasproductos/{panaderiaId}/{productoId}", relacion);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                return null;
            
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<PanaderiaProductoDto>();
        }

        /// <summary>
        /// Elimina una relación
        /// </summary>
        public async Task<bool> EliminarRelacionAsync(int panaderiaId, int productoId)
        {
            var response = await _httpClient.DeleteAsync($"api/panaderiasproductos/{panaderiaId}/{productoId}");
            return response.IsSuccessStatusCode;
        }

        #endregion

        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                _httpClient.Dispose();
            }
        }
    }
}
