using Actividad6.Core;
using Actividad6.Services;
using Microsoft.AspNetCore.Mvc;

namespace Actividad6.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PanaderiasController : ControllerBase
    {
        private readonly IPanaderiaService _panaderiaService;

        public PanaderiasController(IPanaderiaService panaderiaService)
        {
            _panaderiaService = panaderiaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Panaderia>>> GetAll()
        {
            var panaderias = await _panaderiaService.ObtenerPanaderiasAsync();
            return Ok(panaderias);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Panaderia>> GetById(int id)
        {
            var panaderia = await _panaderiaService.ObtenerPanaderiaPorIdAsync(id);
            if (panaderia == null)
                return NotFound();

            return Ok(panaderia);
        }

        [HttpPost]
        public async Task<ActionResult<Panaderia>> Create([FromBody] Panaderia panaderia)
        {
            var created = await _panaderiaService.AgregarPanaderiaAsync(panaderia);
            return CreatedAtAction(nameof(GetById), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Panaderia>> Update(int id, [FromBody] Panaderia panaderia)
        {
            var updated = await _panaderiaService.ActualizarPanaderiaAsync(id, panaderia);
            if (updated == null)
                return NotFound();

            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var deleted = await _panaderiaService.EliminarPanaderiaAsync(id);
            if (!deleted)
                return NotFound();

            return NoContent();
        }
    }
}
