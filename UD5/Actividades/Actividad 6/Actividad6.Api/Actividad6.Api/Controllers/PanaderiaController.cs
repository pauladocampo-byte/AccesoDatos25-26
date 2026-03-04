using Actividad6.Core;
using Actividad6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Actividad6.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PanaderiaController : ControllerBase
    {
        private readonly IPanaderiaService _panaderiaService;

        public PanaderiaController(IPanaderiaService panaderiaService)
        {
            _panaderiaService = panaderiaService;
        }

        [HttpGet]
        public ActionResult<List<Panaderia>> GetAll()
        {
            var panaderias = _panaderiaService.ObtenerTodas();
            return Ok(panaderias);
        }

        [HttpPost]
        public ActionResult Create([FromBody] Panaderia panaderia)
        {
            _panaderiaService.Crear(panaderia);
            return CreatedAtAction(nameof(GetAll), new { id = panaderia.Id }, panaderia);

        }
    }
}
