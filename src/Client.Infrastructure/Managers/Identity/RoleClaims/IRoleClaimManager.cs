using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectServices.Application.Requests.Identity;
using ProjectServices.Application.Responses.Identity;
using ProjectServices.Shared.Wrapper;

namespace ProjectServices.Client.Infrastructure.Managers.Identity.RoleClaims
{
    public interface IRoleClaimManager : IManager
    {
        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsAsync();

        Task<IResult<List<RoleClaimResponse>>> GetRoleClaimsByRoleIdAsync(string roleId);

        Task<IResult<string>> SaveAsync(RoleClaimRequest role);

        Task<IResult<string>> DeleteAsync(string id);
    }
}