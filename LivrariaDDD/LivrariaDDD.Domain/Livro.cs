using System;

namespace LivrariaDDD.Domain
{
    public class Livro
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public decimal Preco { get; set; }
        public Autor Autor { get; set; }
    }
}
