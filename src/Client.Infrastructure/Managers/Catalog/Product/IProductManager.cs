using ProjectServices.Application.Features.Products.Commands.AddEdit;
using ProjectServices.Application.Features.Products.Queries.GetAllPaged;
using ProjectServices.Application.Requests.Catalog;
using ProjectServices.Shared.Wrapper;
using System.Threading.Tasks;

namespace ProjectServices.Client.Infrastructure.Managers.Catalog.Product
{
    public interface IProductManager : IManager
    {
        Task<PaginatedResult<GetAllPagedProductsResponse>> GetProductsAsync(GetAllPagedProductsRequest request);

        Task<IResult<string>> GetProductImageAsync(int id);

        Task<IResult<int>> SaveAsync(AddEditProductCommand request);

        Task<IResult<int>> DeleteAsync(int id);

        Task<IResult<string>> ExportToExcelAsync(string searchString = "");
    }
}