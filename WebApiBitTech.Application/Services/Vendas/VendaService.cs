using WebApiBitTech.Domain.Models;
using WebApiBitTech.Infrastructure.Repositories.Vendas;

namespace WebApiBitTech.Application.Services.Vendas
{
    public class VendaService : IVendaService
    {
        private readonly IVendaRepository _vendaRepository;

        public VendaService(IVendaRepository vendaRepository)
        {
            _vendaRepository = vendaRepository;
        }

        public IEnumerable<Venda> ObterTodas()
        {
            return _vendaRepository.ObterTodas();
        }

        public Venda ObterPorId(Guid id)
        {
            return _vendaRepository.ObterPorId(id);
        }

        public void AdicionarVenda(Venda venda)
        {
            _vendaRepository.Adicionar(venda);
        }

        public void RemoverVenda(Guid id)
        {
            _vendaRepository.Remover(id);
        }
    }
}
