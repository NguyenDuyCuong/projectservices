using ProjectServices.Application.Interfaces.Common;
using ProjectServices.Application.Requests.Identity;
using ProjectServices.Application.Responses.Identity;
using ProjectServices.Shared.Wrapper;
using System.Threading.Tasks;

namespace ProjectServices.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}