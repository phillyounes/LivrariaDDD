using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.ViewModel
{
    public class LivroViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public decimal Preco { get; set; }
        public AutorViewModel Autor { get; set; }
    }
}
