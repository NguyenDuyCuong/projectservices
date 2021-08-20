using ProjectServices.Application.Interfaces.Common;

namespace ProjectServices.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}