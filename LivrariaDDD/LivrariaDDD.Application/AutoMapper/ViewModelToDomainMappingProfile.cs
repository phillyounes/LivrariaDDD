using AutoMapper;
using LivrariaDDD.Application.ViewModel;
using LivrariaDDD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace LivrariaDDD.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<AutorViewModel, Autor>()
             .ForMember(dest => dest.Livros, opt => opt.MapFrom(src => src.Livros))
             .ReverseMap();
            CreateMap<ItemPedidoViewModel, ItemPedido>()
                .ForMember(dest => dest.Pedido, opt => opt.MapFrom(src => src.Pedido))
                .ForMember(dest => dest.Livro, opt => opt.MapFrom(src => src.Livro))
                .ReverseMap();
            CreateMap<LivroViewModel, Livro>()
                .ForMember(dest => dest.Autor, opt => opt.MapFrom(src => src.Autor))
                .ReverseMap();
            CreateMap<PedidoViewModel, Pedido>()
                .ForMember(dest => dest.ItensDoPedido, opt => opt.MapFrom(src => src.ItensDoPedido))
                .ReverseMap();
        }
    }
}
