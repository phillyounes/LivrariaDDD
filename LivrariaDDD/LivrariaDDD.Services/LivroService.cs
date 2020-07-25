using LivrariaDDD.Domain;
using LivrariaDDD.Repository.Interfaces;
using LivrariaDDD.Services.Interfaces;
using System.Collections.Generic;

namespace LivrariaDDD.Services
{
    public class LivroService : ILivroService
    {
        private readonly ILivroRepository _livroRepository;
        public LivroService(ILivroRepository livroRepository)
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
