using Actividad6.Core;
using Actividad6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Actividad6.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PanaderiasProductosController : ControllerBase
    {
        private readonly IPanaderiaProductoService _panaderiaProductoService;

        public PanaderiasProductosController(IPanaderiaProductoService panaderiaProductoService)
        {
            _panaderiaProductoService = panaderiaProductoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<PanaderiaProductoDto>>> GetAll()
        {
            var relaciones = await _panaderiaProductoService.ObtenerRelacionesAsync();
            var dtos = relaciones.Select(pp => new PanaderiaProductoDto
            {
                PanaderiaId = pp.PanaderiaId,
                PanaderiaNombre = pp.Panaderia?.Nombre ?? string.Empty,
                ProductoId = pp.ProductoId,
                ProductoNombre = pp.Producto?.Nombre ?? string.Empty,
                Precio = pp.Precio,
                Stock = pp.Stock
            }).ToList();

            return Ok(dtos);
        }

        [HttpGet("{panaderiaId}/{productoId}")]
        public async Task<ActionResult<PanaderiaProductoDto>> GetById(int panaderiaId, int productoId)
        {
            var relacion = await _panaderiaProductoService.ObtenerRelacionAsync(panaderiaId, productoId);
            if (relacion == null)
                return NotFound();

            var dto = new PanaderiaProductoDto
            {
                PanaderiaId = relacion.PanaderiaId,
                PanaderiaNombre = relacion.Panaderia?.Nombre ?? string.Empty,
                ProductoId = relacion.ProductoId,
                ProductoNombre = relacion.Producto?.Nombre ?? string.Empty,
                Precio = relacion.Precio,
                Stock = relacion.Stock
            };

            return Ok(dto);
        }

        [HttpPost]
        public async Task<ActionResult<PanaderiaProducto>> Create([FromBody] PanaderiaProductoCreateDto dto)
        {
            var relacion = new PanaderiaProducto
            {
                PanaderiaId = dto.PanaderiaId,
                ProductoId = dto.ProductoId,
                Precio = dto.Precio,
                Stock = dto.Stock
            };

            var created = await _panaderiaProductoService.AgregarRelacionAsync(relacion);
            return CreatedAtAction(nameof(GetById), 
                new { panaderiaId = created.PanaderiaId, productoId = created.ProductoId }, created);
        }

        [HttpPut("{panaderiaId}/{productoId}")]
        public async Task<ActionResult<PanaderiaProducto>> Update(int panaderiaId, int productoId, [FromBody] PanaderiaProductoUpdateDto dto)
        {
            var relacion = new PanaderiaProducto
            {
                PanaderiaId = panaderiaId,
                ProductoId = productoId,
                Precio = dto.Precio,
                Stock = dto.Stock
            };

            var updated = await _panaderiaProductoService.ActualizarRelacionAsync(panaderiaId, productoId, relacion);
            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{panaderiaId}/{productoId}")]
        public async Task<ActionResult> Delete(int panaderiaId, int productoId)
        {
            var deleted = await _panaderiaProductoService.EliminarRelacionAsync(panaderiaId, productoId);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }

    // DTOs para la API
    public class PanaderiaProductoDto
    {
        public int PanaderiaId { get; set; }
        public string PanaderiaNombre { get; set; } = string.Empty;
        public int ProductoId { get; set; }
        public string ProductoNombre { get; set; } = string.Empty;
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }

    public class PanaderiaProductoCreateDto
    {
        public int PanaderiaId { get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }

    public class PanaderiaProductoUpdateDto
    {
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
