using LivrariaDDD.Application.ViewModel;
using System.Collections.Generic;

namespace LivrariaDDD.Application.Interfaces
{
    public interface IAutorApp
    {   
        void Create(AutorViewModel autor);
        AutorViewModel Read(int id);
        IEnumerable<AutorViewModel> ReadAll();
        void Update(AutorViewModel autor);
        void Delete(AutorViewModel autor);
    }
}
