using AutoMapper;
using LivrariaDDD.Application.ViewModel;
using LivrariaDDD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Autor, AutorViewModel>()
                .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => src.Livros))
                .ReverseMap();
            CreateMap<ItemPedido, ItemPedidoViewModel>()
                .ForMember(dest => dest.Pedido, opt => opt.MapFrom(src => src.Pedido))
                .ForMember(dest => dest.Livro, opt => opt.MapFrom(src => src.Livro))
                .ReverseMap();
            CreateMap<Livro, LivroViewModel>()
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => src.Autor))
                .ReverseMap();
            CreateMap<Pedido, PedidoViewModel>()
                .ForMember(dest => dest.ItensDoPedido, opt => opt.MapFrom(src => src.ItensDoPedido))
                .ReverseMap();
        }
    }

}
