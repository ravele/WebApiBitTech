using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Infrastructure.Repositories.Garantias
{
    public interface IGarantiaRepository
    {
        IEnumerable<Garantia> ObterTodas();
        Garantia ObterPorId(Guid id);
        void Adicionar(Garantia garantia);
        void Atualizar(Garantia garantia);
        void Remover(Guid id);
    }
}
