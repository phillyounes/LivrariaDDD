using LivrariaDDD.Domain;
using System.Collections.Generic;

namespace LivrariaDDD.Service.Interfaces
{
    public interface ILivroService
    {
        void Create(Livro livro);
        Livro Read(int id);
        IEnumerable<Livro> ReadAll();
        void Update(Livro livro);
        void Delete(Livro livro);
    }
}
