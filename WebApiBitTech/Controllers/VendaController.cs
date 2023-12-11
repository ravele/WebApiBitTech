using Microsoft.AspNetCore.Mvc;
using WebApiBitTech.Application.Services.Vendas;
using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Controllers
{
    [ApiController]
    [Route("api/vendas")]
    public class VendaController : ControllerBase
    {
        private readonly IVendaService _vendaService;

        public VendaController(IVendaService vendaService)
        {
            _vendaService = vendaService;
        }

        [HttpGet]
        public IEnumerable<Venda> ObterTodas()
        {
            return _vendaService.ObterTodas();
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(Guid id)
        {
            var venda = _vendaService.ObterPorId(id);
            if (venda == null)
            {
                return NotFound();
            }
            return Ok(venda);
        }

        [HttpPost]
        public IActionResult AdicionarVenda([FromBody] Venda venda)
        {
            _vendaService.AdicionarVenda(venda);
            return CreatedAtAction(nameof(ObterPorId), new { id = venda.Id }, venda);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverVenda(Guid id)
        {
            _vendaService.RemoverVenda(id);
            return NoContent();
        }
    }
}
