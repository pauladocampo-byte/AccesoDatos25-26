using Actividad6.Core;
using Actividad6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Actividad6.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductosController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Producto>>> GetAll()
        {
            var productos = await _productoService.ObtenerProductosAsync();
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> GetById(int id)
        {
            var producto = await _productoService.ObtenerProductoPorIdAsync(id);
            if (producto == null)
                return NotFound();

            return Ok(producto);
        }

        [HttpPost]
        public async Task<ActionResult<Producto>> Create([FromBody] Producto producto)
        {
            var created = await _productoService.AgregarProductoAsync(producto);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Producto>> Update(int id, [FromBody] Producto producto)
        {
            var updated = await _productoService.ActualizarProductoAsync(id, producto);
            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _productoService.EliminarProductoAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
