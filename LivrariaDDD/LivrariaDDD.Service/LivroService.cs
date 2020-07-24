using LivrariaDDD.Domain;
using LivrariaDDD.Repository;
using LivrariaDDD.Service.Interfaces;
using System.Collections.Generic;

namespace LivrariaDDD.Service
{
    public class LivroService : ILivroService
    {
        private readonly LivroRepository _livroRepository;
        public LivroService(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        public void Create(Livro livro)
        {
            _livroRepository.Create(livro);
        }

        public void Delete(Livro livro)
        {
            _livroRepository.Delete(livro);
        }

        public Livro Read(int id)
        {
            return _livroRepository.Read(id);
        }

        public IEnumerable<Livro> ReadAll()
        {
            return _livroRepository.ReadAll();
        }

        public void Update(Livro livro)
        {
            _livroRepository.Update(livro);
        }
    }
}
