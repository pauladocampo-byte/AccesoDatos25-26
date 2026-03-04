using Actividad6.Api.DTO;
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
        public ActionResult<List<PanaderiaProducto>> GetAll()
        {
            var panaderiasProductos = _panaderiaProductoService.ObtenerTodas();
            return Ok(panaderiasProductos);
        }

        [HttpPost]
        public ActionResult Create([FromBody] PanaderiaProductoCreateDto panaderiaProductoCreateDto)
        {
            if (_panaderiaProductoService.Existe(panaderiaProductoCreateDto.PanaderiaId, panaderiaProductoCreateDto.ProductoId))
            {
                return Conflict("La relación entre la panadería y el producto ya existe.");
            }
            var panaderiaProducto = new PanaderiaProducto
            {
                PanaderiaId = panaderiaProductoCreateDto.PanaderiaId,
                ProductoId = panaderiaProductoCreateDto.ProductoId,
                Precio = panaderiaProductoCreateDto.Precio,
                Stock = panaderiaProductoCreateDto.Stock
            };

            _panaderiaProductoService.Crear(panaderiaProducto);
            return CreatedAtAction(nameof(GetAll), new { panaderiaId = panaderiaProducto.PanaderiaId, productoId = panaderiaProducto.ProductoId }, panaderiaProducto);
        }
    }
}
