using Microsoft.AspNetCore.Mvc;
using WebApiBitTech.Application.Services.Garantias;
using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Controllers
{
    [ApiController]
    [Route("api/garantias")]
    public class GarantiaController : ControllerBase
    {
        private readonly IGarantiaService _garantiaService;

        public GarantiaController(IGarantiaService garantiaService)
        {
            _garantiaService = garantiaService;
        }

        [HttpGet]
        public IEnumerable<Garantia> ObterTodas()
        {
            return _garantiaService.ObterTodas();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(Guid id)
        {
            var garantia = _garantiaService.ObterPorId(id);
            if (garantia == null)
            {
                return NotFound();
            }
            return Ok(garantia);
        }

        [HttpPost]
        public IActionResult AdicionarGarantia([FromBody] Garantia garantia)
        {
            _garantiaService.AdicionarGarantia(garantia);
            return CreatedAtAction(nameof(ObterPorId), new { id = garantia.Id }, garantia);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarGarantia(Guid id, [FromBody] Garantia garantia)
        {
            if (id != garantia.Id)
            {
                return BadRequest();
            }

            _garantiaService.AtualizarGarantia(garantia);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverGarantia(Guid id)
        {
            _garantiaService.RemoverGarantia(id);
            return NoContent();
        }
    }
}
