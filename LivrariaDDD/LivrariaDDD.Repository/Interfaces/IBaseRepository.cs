using System.Collections.Generic;

namespace LivrariaDDD.Repository.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        void Create(T entity);
        T Read(int id);
        IEnumerable<T> ReadAll();
        void Update(T entity);
        void Delete(T entity);
    }
}
