using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Infrastructure.Repositories.Vendas
{
    public class VendaRepository : IVendaRepository
    {
        private List<Venda> _vendas = new List<Venda>();

        public IEnumerable<Venda> ObterTodas()
        {
            return _vendas;
        }

        public Venda ObterPorId(Guid id)
        {
            return _vendas.FirstOrDefault(v => v.Id == id);
        }

        public void Adicionar(Venda venda)
        {
            venda.Id = Guid.NewGuid();
            _vendas.Add(venda);
        }

        public void Remover(Guid id)
        {
            _vendas.RemoveAll(v => v.Id == id);
        }
    }
}
