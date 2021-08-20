using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectServices.Application.Features.DocumentTypes.Commands.AddEdit;
using ProjectServices.Application.Features.DocumentTypes.Queries.GetAll;
using ProjectServices.Shared.Wrapper;

namespace ProjectServices.Client.Infrastructure.Managers.Misc.DocumentType
{
    public interface IDocumentTypeManager : IManager
    {
        Task<IResult<List<GetAllDocumentTypesResponse>>> GetAllAsync();

        Task<IResult<int>> SaveAsync(AddEditDocumentTypeCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}