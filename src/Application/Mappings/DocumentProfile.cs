using AutoMapper;
using ProjectServices.Application.Features.Documents.Commands.AddEdit;
using ProjectServices.Application.Features.Documents.Queries.GetById;
using ProjectServices.Domain.Entities.Misc;

namespace ProjectServices.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}