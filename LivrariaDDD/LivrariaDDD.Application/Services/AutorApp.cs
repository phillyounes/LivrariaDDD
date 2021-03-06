﻿using AutoMapper;
using LivrariaDDD.Application.Interfaces;
using LivrariaDDD.Application.ViewModel;
using LivrariaDDD.Domain;
using LivrariaDDD.Services.Interfaces;
using System.Collections.Generic;

namespace LivrariaDDD.Application.Services
{
    public class AutorApp : IAutorApp
    {
        private readonly IAutorService _autorService;
        private readonly IMapper _mapper;
        public AutorApp(IAutorService autorService, IMapper mapper)
        {
            _autorService = autorService;
            _mapper = mapper;
        }
        public void Create(AutorViewModel autor)
        {
            _autorService.Create(_mapper.Map<Autor>(autor));
        }

        public void Delete(AutorViewModel autor)
        {
            _autorService.Delete(_mapper.Map<Autor>(autor));
        }

        public AutorViewModel Read(int id)
        {
            var autor = _autorService.Read(id);
            return _mapper.Map<AutorViewModel>(autor);
        }

        public IEnumerable<AutorViewModel> ReadAll()
        {
            var autores = _autorService.ReadAll();
            return _mapper.Map<List<AutorViewModel>>(autores);
        }

        public void Update(AutorViewModel autor)
        {
            _autorService.Update(_mapper.Map<Autor>(autor));
        }
    }
}
