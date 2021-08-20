using AutoMapper;
using ProjectServices.Application.Interfaces.Chat;
using ProjectServices.Application.Models.Chat;
using ProjectServices.Infrastructure.Models.Identity;

namespace ProjectServices.Infrastructure.Mappings
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<BlazorHeroUser>>().ReverseMap();
        }
    }
}