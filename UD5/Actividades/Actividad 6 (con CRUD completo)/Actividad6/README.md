# Actividad 6 - Arquitectura API + Cliente NuGet + Frontend

## Estructura del Proyecto (3 Soluciones Independientes)

```
Actividad6/
?
??? Backend/                              # SOLUCIÓN 1: API REST
?   ??? Actividad6.Backend.sln
?   ??? Actividad6.Core/                  # Entidades del dominio
?   ??? Actividad6.Data/                  # DbContext y EF Core
?   ??? Actividad6.Services/              # Lógica de negocio
?   ??? Actividad6.Api/                   # Controladores API REST
?
??? ClienteApi/                           # SOLUCIÓN 2: SDK/Cliente NuGet
?   ??? Actividad6.ClienteApi.sln
?   ??? Actividad6.ClienteApi/            # Cliente HTTP (genera paquete NuGet)
?       ??? Models/                       # DTOs del cliente
?       ??? PanaderiaApiClient.cs         # Cliente principal
?       ??? nupkg/                        # Paquetes NuGet generados
?
??? Frontend/                             # SOLUCIÓN 3: Aplicación Windows Forms
    ??? Actividad6.Frontend.sln
    ??? nuget.config                      # Configuración feed NuGet local
    ??? Actividad6.Frontend/              # Windows Forms App
```

## ¿Por qué 3 soluciones separadas?

| Solución | Responsabilidad | Equipo |
|----------|-----------------|--------|
| **Backend** | API REST, base de datos, lógica de negocio | Equipo Backend |
| **ClienteApi** | SDK/librería para consumir la API | Equipo Backend (publica NuGet) |
| **Frontend** | Interfaz de usuario | Equipo Frontend (consume NuGet) |

**Ventajas de esta arquitectura:**
- ? **Separación de responsabilidades**: Cada solución tiene un propósito claro
- ? **Independencia de equipos**: Frontend y Backend pueden trabajar por separado
- ? **Versionado independiente**: El ClienteApi puede versionarse y publicarse como NuGet
- ? **Reutilización**: Múltiples frontends pueden usar el mismo ClienteApi

## Requisitos

- .NET 8.0 SDK
- SQL Server LocalDB (o modificar la cadena de conexión)

## Configuración y Ejecución

### 1. Crear la Base de Datos (Backend)

```bash
cd Actividad6/Backend/Actividad6.Data
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 2. Ejecutar la API (Backend)

```bash
cd Actividad6/Backend/Actividad6.Api
dotnet run
```

La API estará disponible en:
- http://localhost:5000
- Swagger UI: http://localhost:5000/swagger

### 3. Generar el paquete NuGet (ClienteApi)

```bash
cd Actividad6/ClienteApi/Actividad6.ClienteApi
dotnet build --configuration Release
```

El paquete se genera en: `ClienteApi/Actividad6.ClienteApi/nupkg/`

### 4. Ejecutar el Frontend

```bash
cd Actividad6/Frontend/Actividad6.Frontend
dotnet run
```

## Opciones para usar el ClienteApi en el Frontend

### Opción A: Referencia de proyecto (desarrollo)

En el `.csproj` del Frontend:
```xml
<ProjectReference Include="..\..\ClienteApi\Actividad6.ClienteApi\Actividad6.ClienteApi.csproj" />
```

### Opción B: Paquete NuGet (producción)

```xml
<PackageReference Include="Actividad6.ClienteApi" Version="1.0.0" />
```

## Endpoints de la API

### Panaderías
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| GET | `/api/panaderias` | Obtener todas |
| GET | `/api/panaderias/{id}` | Obtener por ID |
| POST | `/api/panaderias` | Crear |
| PUT | `/api/panaderias/{id}` | Actualizar |
| DELETE | `/api/panaderias/{id}` | Eliminar |

### Productos
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| GET | `/api/productos` | Obtener todos |
| GET | `/api/productos/{id}` | Obtener por ID |
| POST | `/api/productos` | Crear |
| PUT | `/api/productos/{id}` | Actualizar |
| DELETE | `/api/productos/{id}` | Eliminar |

### Panaderías-Productos
| Método | Endpoint | Descripción |
|--------|----------|-------------|
| GET | `/api/panaderiasproductos` | Obtener todas las relaciones |
| GET | `/api/panaderiasproductos/{panaderiaId}/{productoId}` | Obtener relación |
| POST | `/api/panaderiasproductos` | Crear relación |
| PUT | `/api/panaderiasproductos/{panaderiaId}/{productoId}` | Actualizar |
| DELETE | `/api/panaderiasproductos/{panaderiaId}/{productoId}` | Eliminar |

## Ejemplo de uso del Cliente API

```csharp
using Actividad6.ClienteApi;
using Actividad6.ClienteApi.Models;

// Crear instancia del cliente
using var client = new PanaderiaApiClient("http://localhost:5000");

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
