using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.ViewModel
{
    public class ItemPedidoViewModel
    {
        public int Id { get; set; }
        public PedidoViewModel Pedido { get; set; }
        public LivroViewModel Livro { get; set; }
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
