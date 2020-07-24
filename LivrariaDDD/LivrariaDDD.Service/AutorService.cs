using LivrariaDDD.Domain;
using LivrariaDDD.Repository;
using LivrariaDDD.Service.Interfaces;
using System.Collections.Generic;

namespace LivrariaDDD.Service
{
    public class AutorService : IAutorService
    {
        private readonly AutorRepository _autorRepository;
        public AutorService(AutorRepository autorRepository)
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
