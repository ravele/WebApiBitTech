using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Application.Services.Vendas
{
    public interface IVendaService
    {
        IEnumerable<Venda> ObterTodas();
        Venda ObterPorId(Guid id);
        void AdicionarVenda(Venda venda);
        void RemoverVenda(Guid id);
    }
}
