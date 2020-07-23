using System;
using System.Collections;
using System.Collections.Generic;

namespace LivrariaDDD.Domain
{
    public class Autor
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }
    }
}
