using AutoMapper;
using LivrariaDDD.Application.Interfaces;
using LivrariaDDD.Application.ViewModel;
using LivrariaDDD.Domain;
using LivrariaDDD.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.Services
{
    public class LivroApp : ILivroApp
    {
        private readonly ILivroService _livroService;
        private readonly IMapper _mapper;
        public LivroApp(ILivroService livroService , IMapper mapper)
        {
            _livroService = livroService;
            _mapper = mapper;
        }
        public void Create(LivroViewModel livro)
        {
            _livroService.Create(_mapper.Map<Livro>(livro));
        }

        public void Delete(LivroViewModel livro)
        {
            _livroService.Delete(_mapper.Map<Livro>(livro));
        }

        public LivroViewModel Read(int id)
        {
            var livro = _livroService.Read(id);
            return _mapper.Map<LivroViewModel>(livro);
        }

        public IEnumerable<LivroViewModel> ReadAll()
        {
            var livros = _livroService.ReadAll();
            return _mapper.Map<List<LivroViewModel>>(livros);
        }

        public void Update(LivroViewModel livro)
        {
            _livroService.Update(_mapper.Map<Livro>(livro));
        }
    }
}
