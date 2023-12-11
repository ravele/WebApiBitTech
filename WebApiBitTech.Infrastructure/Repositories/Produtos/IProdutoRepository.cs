using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Infrastructure.Repositories.Produtos
{
    public interface IProdutoRepository
    {
        List<Produto> ObterTodos();
        Produto ObterPorId(Guid id);
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(Guid id);
    }
}
