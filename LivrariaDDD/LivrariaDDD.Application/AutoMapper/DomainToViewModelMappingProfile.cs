using AutoMapper;
using LivrariaDDD.Application.ViewModel;
using LivrariaDDD.Domain;

namespace LivrariaDDD.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Autor, AutorViewModel>()
                .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => src.Livros))
                .ReverseMap();
            CreateMap<Livro, LivroViewModel>()
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => src.Autor))
                .ReverseMap();
        }
    }

}
