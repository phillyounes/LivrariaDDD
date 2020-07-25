using LivrariaDDD.Domain;
using LivrariaDDD.Repository.Interfaces;
using LivrariaDDD.Services.Interfaces;
using System.Collections.Generic;

namespace LivrariaDDD.Services
{
    public class AutorService : IAutorService
    {
        private readonly IAutorRepository _autorRepository;
        public AutorService(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public void Create(Autor autor)
        {
            _autorRepository.Create(autor);
        }

        public void Delete(Autor autor)
        {
            _autorRepository.Delete(autor);
        }

        public Autor Read(int id)
        {
            return _autorRepository.Read(id);
        }

        public IEnumerable<Autor> ReadAll()
        {
            return _autorRepository.ReadAll();
        }

        public void Update(Autor autor)
        {
            _autorRepository.Update(autor);
        }
    }
}
