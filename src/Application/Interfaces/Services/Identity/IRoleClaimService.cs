using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectServices.Application.Interfaces.Common;
using ProjectServices.Application.Requests.Identity;
using ProjectServices.Application.Responses.Identity;
using ProjectServices.Shared.Wrapper;

namespace ProjectServices.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}