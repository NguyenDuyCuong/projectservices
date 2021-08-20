using ProjectServices.Application.Models.Chat;
using ProjectServices.Application.Responses.Identity;
using ProjectServices.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectServices.Application.Interfaces.Chat;

namespace ProjectServices.Client.Infrastructure.Managers.Communication
{
    public interface IChatManager : IManager
    {
        Task<IResult<IEnumerable<ChatUserResponse>>> GetChatUsersAsync();

        Task<IResult> SaveMessageAsync(ChatHistory<IChatUser> chatHistory);

        Task<IResult<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string cId);
    }
}