using WebApiBitTech.Domain.Models;
using WebApiBitTech.Infrastructure.Repositories.Garantias;

namespace WebApiBitTech.Application.Services.Garantias
{
    public class GarantiaService : IGarantiaService
    {
        private readonly IGarantiaRepository _garantiaRepository;

        public GarantiaService(IGarantiaRepository garantiaRepository)
        {
            _garantiaRepository = garantiaRepository;
        }

        public IEnumerable<Garantia> ObterTodas()
        {
            return _garantiaRepository.ObterTodas();
        }

        public Garantia ObterPorId(Guid id)
        {
            return _garantiaRepository.ObterPorId(id);
        }

        public void AdicionarGarantia(Garantia garantia)
        {
            _garantiaRepository.Adicionar(garantia);
        }

        public void AtualizarGarantia(Garantia garantia)
        {
            _garantiaRepository.Atualizar(garantia);
        }

        public void RemoverGarantia(Guid id)
        {
            _garantiaRepository.Remover(id);
        }
    }
}
