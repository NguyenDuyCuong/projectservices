using AutoMapper;
using ProjectServices.Application.Features.Brands.Commands.AddEdit;
using ProjectServices.Application.Features.Brands.Queries.GetAll;
using ProjectServices.Application.Features.Brands.Queries.GetById;
using ProjectServices.Domain.Entities.Catalog;

namespace ProjectServices.Application.Mappings
{
    public class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<AddEditBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsResponse, Brand>().ReverseMap();
        }
    }
}