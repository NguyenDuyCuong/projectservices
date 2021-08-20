using AutoMapper;
using ProjectServices.Application.Features.DocumentTypes.Commands.AddEdit;
using ProjectServices.Application.Features.DocumentTypes.Queries.GetAll;
using ProjectServices.Application.Features.DocumentTypes.Queries.GetById;
using ProjectServices.Domain.Entities.Misc;

namespace ProjectServices.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}