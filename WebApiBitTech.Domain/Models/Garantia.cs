namespace WebApiBitTech.Domain.Models
{
    public class Garantia
    {
        public Guid Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public decimal Valor { get; set; }
        public int Prazo { get; set; }
    }
}
