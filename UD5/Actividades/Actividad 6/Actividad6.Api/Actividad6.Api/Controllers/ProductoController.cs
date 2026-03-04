using Actividad6.Core;
using Actividad6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Actividad6.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService productoService)
        {
            _productoService = productoService;
        }

        [HttpGet]
        public ActionResult<List<Producto>> GetAll()
        {
            var productos = _productoService.ObtenerTodos();
            return Ok(productos);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Producto producto)
        {
            _productoService.Crear(producto);
            return CreatedAtAction(nameof(GetAll), new { id = producto.Id }, producto);

        }

    }
}
