using AutoMapper;
using OnionArchitectureDemo.Application.Dtos;
using OnionArchitectureDemo.Application.Features.Commands.CreateProduct;
using OnionArchitectureDemo.Domain.Entities;

namespace OnionArchitectureDemo.Application.Mapping.GeneralMapping;

public class GeneralMapping : Profile
{
    public GeneralMapping()
    {
        CreateMap<Product, ProductViewDto>().ReverseMap();
        CreateMap<Product, CreateProductCommand>().ReverseMap();
    }
}