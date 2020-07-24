using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.ViewModel
{
    public class AutorViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<LivroViewModel> Livros { get; set; }
    }
}
