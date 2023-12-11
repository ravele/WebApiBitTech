using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Application.Services.Produtos
{
    public interface IProdutoService
    {
        List<Produto> ObterTodos();
        Produto ObterPorId(Guid id);
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
        void Remover(Guid id);
    }
}
