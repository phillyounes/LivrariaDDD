namespace LivrariaDDD.Domain
{
    public class ItemPedido
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public Livro Livro { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public virtual decimal ValorTotal
        {
            get
            {
                return Quantidade * Preco;
            }
        }
    }
}
