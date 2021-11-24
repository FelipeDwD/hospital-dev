using Hospital.WebApi.Domain.Models.Email;
using System.Net.Mail;

namespace Hospital.WebApi.Domain.Interfaces.Services.Email
{
    public interface ISmtpClientService
    {
        SmtpClient Get(EmailSettings emailSettings);
    }
}
