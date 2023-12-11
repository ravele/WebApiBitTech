using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Application.Services.Garantias
{
    public interface IGarantiaService
    {
        IEnumerable<Garantia> ObterTodas();
        Garantia ObterPorId(Guid id);
        void AdicionarGarantia(Garantia garantia);
        void AtualizarGarantia(Garantia garantia);
        void RemoverGarantia(Guid id);
    }
}
