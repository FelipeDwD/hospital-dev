using Hospital.WebApi.Domain.Models.Email;
using System.Net.Mail;

namespace Hospital.WebApi.Domain.Interfaces.Services.Email
{
    public interface IMailMessageService
    {
        MailMessage Get(EmailRequest emailRequest, EmailSettings emailSettings);
    }
}
