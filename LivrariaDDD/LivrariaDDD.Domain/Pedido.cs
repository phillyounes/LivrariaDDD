using System;
using System.Collections.Generic;

namespace LivrariaDDD.Domain
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeItens { get; set; }
        public List<ItemPedido> ItensDoPedido { get; set; }
    }
}
