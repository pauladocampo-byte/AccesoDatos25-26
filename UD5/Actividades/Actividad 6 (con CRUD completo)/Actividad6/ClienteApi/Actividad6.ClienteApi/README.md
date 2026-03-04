# Actividad6.ClienteApi

Cliente HTTP para consumir la API de Panadería.

## Instalación

```bash
dotnet add package Actividad6.ClienteApi
```

## Uso básico

```csharp
using Actividad6.ClienteApi;
using Actividad6.ClienteApi.Models;

// Crear instancia del cliente (producción)
using var client = new PanaderiaApiClient("https://mi-api.com");

// Para desarrollo con HTTPS y certificado autofirmado
using var clientDev = new PanaderiaApiClient("https://localhost:5001", ignorarCertificadoSsl: true);

// Obtener todas las panaderías
var panaderias = await client.ObtenerPanaderiasAsync();

// Crear una nueva panadería
var nuevaPanaderia = new PanaderiaDto 
{ 
    Nombre = "Mi Panadería",
    Direccion = "Calle 123",
    Telefono = "555-1234"
};
var creada = await client.CrearPanaderiaAsync(nuevaPanaderia);

// Obtener todos los productos
var productos = await client.ObtenerProductosAsync();

// Crear un producto
var producto = new ProductoDto { Nombre = "Pan de molde" };
await client.CrearProductoAsync(producto);
```

## Métodos disponibles

### Panaderías
- `ObtenerPanaderiasAsync()` - Obtener todas las panaderías
- `ObtenerPanaderiaPorIdAsync(int id)` - Obtener una panadería por ID
- `CrearPanaderiaAsync(PanaderiaDto panaderia)` - Crear nueva panadería
- `ActualizarPanaderiaAsync(int id, PanaderiaDto panaderia)` - Actualizar panadería
- `EliminarPanaderiaAsync(int id)` - Eliminar panadería

### Productos
- `ObtenerProductosAsync()` - Obtener todos los productos
- `ObtenerProductoPorIdAsync(int id)` - Obtener un producto por ID
- `CrearProductoAsync(ProductoDto producto)` - Crear nuevo producto
- `ActualizarProductoAsync(int id, ProductoDto producto)` - Actualizar producto
- `EliminarProductoAsync(int id)` - Eliminar producto

### Relaciones Panadería-Producto
- `ObtenerRelacionesAsync()` - Obtener todas las relaciones
- `ObtenerRelacionAsync(int panaderiaId, int productoId)` - Obtener relación específica
- `CrearRelacionAsync(PanaderiaProductoCreateDto relacion)` - Crear relación
- `ActualizarRelacionAsync(...)` - Actualizar relación
- `EliminarRelacionAsync(int panaderiaId, int productoId)` - Eliminar relación
