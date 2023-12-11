using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Infrastructure.Repositories.Vendas
{
    public interface IVendaRepository
    {
        IEnumerable<Venda> ObterTodas();
        Venda ObterPorId(Guid id);
        void Adicionar(Venda venda);
        void Remover(Guid id);
    }
}
