using ProjectServices.Application.Responses.Identity;
using ProjectServices.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectServices.Application.Interfaces.Chat;
using ProjectServices.Application.Models.Chat;

namespace ProjectServices.Application.Interfaces.Services
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}