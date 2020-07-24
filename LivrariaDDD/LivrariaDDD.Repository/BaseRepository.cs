using LivrariaDDD.Infra.Data;
using LivrariaDDD.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace LivrariaDDD.Repository
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private LivrariaDbContext _context;

        public BaseRepository()
        {
            _context = new LivrariaDbContext();
        }

        public T Read(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IEnumerable<T> ReadAll()
        {
            return _context.Set<T>();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
