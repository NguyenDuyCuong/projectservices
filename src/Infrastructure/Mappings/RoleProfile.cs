using AutoMapper;
using ProjectServices.Infrastructure.Models.Identity;
using ProjectServices.Application.Responses.Identity;

namespace ProjectServices.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}