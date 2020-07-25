using LivrariaDDD.Domain;
using System.Collections.Generic;

namespace LivrariaDDD.Services.Interfaces
{
    public interface ILivroService //: IServiceBase<Livro>
    {
        void Create(Livro livro);
        Livro Read(int id);
        IEnumerable<Livro> ReadAll();
        void Update(Livro livro);
        void Delete(Livro livro);
    }
}
