using AutoMapper;
using ProjectServices.Application.Features.Products.Commands.AddEdit;
using ProjectServices.Domain.Entities.Catalog;

namespace ProjectServices.Application.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<AddEditProductCommand, Product>().ReverseMap();
        }
    }
}