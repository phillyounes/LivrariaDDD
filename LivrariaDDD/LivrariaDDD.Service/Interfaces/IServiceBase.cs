using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Service.Interfaces
{
    public interface IServiceBase<T> where T : class
    {
        void Create(T entity);
        T Read(int id);
        IEnumerable<T> ReadAll();
        void Update(T entity);
        void Delete(T entity);
    }
}
