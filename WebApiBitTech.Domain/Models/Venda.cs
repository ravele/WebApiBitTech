namespace WebApiBitTech.Domain.Models
{
    public class Venda
    {
        public Guid Id { get; set; }
        public List<ItemVenda> ItensDaVenda { get; set; } = new List<ItemVenda>();
        public decimal ValorTotal { get; set; }
        public Garantia Garantia { get; set; } = new Garantia();
    }

    public class ItemVenda
    {
        public Guid IdProduto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
