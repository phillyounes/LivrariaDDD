using LivrariaDDD.Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.Interfaces
{
    public interface ILivroApp
    {
        void Create(LivroViewModel livro);
        LivroViewModel Read(int id);
        IEnumerable<LivroViewModel> ReadAll();
        void Update(LivroViewModel livro);
        void Delete(LivroViewModel livro);
    }
}
