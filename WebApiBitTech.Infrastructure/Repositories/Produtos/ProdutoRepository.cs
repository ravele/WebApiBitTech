using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Infrastructure.Repositories.Produtos
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly List<Produto> _produtos;

        public ProdutoRepository()
        {
            _produtos = new List<Produto>();
        }

        public List<Produto> ObterTodos()
        {
            return _produtos;
        }

        public Produto ObterPorId(Guid id)
        {
            return _produtos.Find(p => p.Id == id);
        }

        public void Adicionar(Produto produto)
        {
            _produtos.Add(produto);
        }

        public void Atualizar(Produto produto)
        {
            var index = _produtos.FindIndex(p => p.Id == produto.Id);
            if (index != -1)
                _produtos[index] = produto;
        }

        public void Remover(Guid id)
        {
            var produto = _produtos.Find(p => p.Id == id);
            if (produto != null)
                _produtos.Remove(produto);
        }
    }
}
