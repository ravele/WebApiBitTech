using Microsoft.AspNetCore.Mvc;
using WebApiBitTech.Application.Services.Produtos;
using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        [HttpGet]
        public ActionResult ObterTodos()
        {
            var produtos = _produtoService.ObterTodos();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(Guid id)
        {
            var produto = _produtoService.ObterPorId(id);
            if (produto == null)
                return NotFound();

            return Ok(produto);
        }

        [HttpPost]
        public IActionResult AdicionarProduto([FromBody] Produto produto)
        {
            _produtoService.Adicionar(produto);
            return CreatedAtAction(nameof(ObterPorId), new { id = produto.Id }, produto);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProduto(Guid id, [FromBody] Produto produto)
        {
            var produtoExistente = _produtoService.ObterPorId(id);
            if (produtoExistente == null)
                return NotFound();

            produto.Id = id;
            _produtoService.Atualizar(produto);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverProduto(Guid id)
        {
            var produto = _produtoService.ObterPorId(id);
            if (produto == null)
                return NotFound();

            _produtoService.Remover(id);
            return NoContent();
        }
    }
}
