﻿using System.Collections.Generic;

namespace LivrariaDDD.Domain
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }
    }
}
