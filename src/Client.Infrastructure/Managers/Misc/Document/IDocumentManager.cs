﻿using ProjectServices.Application.Features.Documents.Commands.AddEdit;
using ProjectServices.Application.Features.Documents.Queries.GetAll;
using ProjectServices.Application.Requests.Documents;
using ProjectServices.Shared.Wrapper;
using System.Threading.Tasks;
using ProjectServices.Application.Features.Documents.Queries.GetById;

namespace ProjectServices.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}