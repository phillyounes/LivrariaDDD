using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.ViewModel
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int Numero { get; set; }
        public string Cliente { get; set; }
        public decimal Valor { get; set; }
        public int QuantidadeItens { get; set; }
        public List<ItemPedidoViewModel> ItensDoPedido { get; set; }
    }
}
