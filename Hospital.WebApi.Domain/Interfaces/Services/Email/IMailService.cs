using Hospital.WebApi.Domain.Models.Email;
using System.Threading.Tasks;

namespace Hospital.WebApi.Domain.Interfaces.Services.Email
{
    public interface IMailService
    {
        Task SendEmailAsync(EmailRequest emailRequest);
    }
}
