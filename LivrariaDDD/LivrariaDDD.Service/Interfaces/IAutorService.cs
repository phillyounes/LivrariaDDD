using LivrariaDDD.Domain;
using System.Collections.Generic;

namespace LivrariaDDD.Service.Interfaces
{
    public interface IAutorService
    {
        void Create(Autor autor);
        Autor Read(int id);
        IEnumerable<Autor> ReadAll();
        void Update(Autor autor);
        void Delete(Autor autor);
    }
}
