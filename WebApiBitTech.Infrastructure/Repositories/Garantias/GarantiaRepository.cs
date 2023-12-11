using WebApiBitTech.Domain.Models;

namespace WebApiBitTech.Infrastructure.Repositories.Garantias
{
    public class GarantiaRepository : IGarantiaRepository
    {
        private List<Garantia> _garantias = new List<Garantia>();

        public IEnumerable<Garantia> ObterTodas()
        {
            return _garantias;
        }

        public Garantia ObterPorId(Guid id)
        {
            return _garantias.FirstOrDefault(g => g.Id == id);
        }

        public void Adicionar(Garantia garantia)
        {
            garantia.Id = Guid.NewGuid();
            _garantias.Add(garantia);
        }

        public void Atualizar(Garantia garantia)
        {
            var index = _garantias.FindIndex(g => g.Id == garantia.Id);
            if (index != -1)
            {
                _garantias[index] = garantia;
            }
        }

        public void Remover(Guid id)
        {
            _garantias.RemoveAll(g => g.Id == id);
        }
    }
}
