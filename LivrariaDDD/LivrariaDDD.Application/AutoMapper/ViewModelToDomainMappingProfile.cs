﻿using AutoMapper;
using LivrariaDDD.Application.ViewModel;
using LivrariaDDD.Domain;

namespace LivrariaDDD.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AutorViewModel, Autor>()
             .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => src.Livros))
             .ReverseMap();
            CreateMap<LivroViewModel, Livro>()
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => src.Autor))
                .ReverseMap();
        }
    }
}
