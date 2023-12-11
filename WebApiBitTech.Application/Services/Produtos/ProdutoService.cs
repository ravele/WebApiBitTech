using WebApiBitTech.Domain.Models;
using WebApiBitTech.Infrastructure.Repositories.Produtos;

namespace WebApiBitTech.Application.Services.Produtos
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> ObterTodos()
        {
            return _produtoRepository.ObterTodos();
        }

        public Produto ObterPorId(Guid id)
        {
            return _produtoRepository.ObterPorId(id);
        }

        public void Adicionar(Produto produto)
        {
            _produtoRepository.Adicionar(produto);
        }

        public void Atualizar(Produto produto)
        {
            _produtoRepository.Atualizar(produto);
        }

        public void Remover(Guid id)
        {
            _produtoRepository.Remover(id);
        }
    }
}
