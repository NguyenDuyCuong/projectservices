using ProjectServices.Application.Requests.Mail;
using System.Threading.Tasks;

namespace ProjectServices.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}