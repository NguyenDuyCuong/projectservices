using AutoMapper;
using ProjectServices.Infrastructure.Models.Audit;
using ProjectServices.Application.Responses.Audit;

namespace ProjectServices.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}