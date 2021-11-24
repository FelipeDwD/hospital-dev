using Hospital.WebApi.Domain.Interfaces.Services.Email;
using Hospital.WebApi.Domain.Models.Email;
using System.Net.Mail;

namespace Hospital.WebApi.Service.Services.Email
{
    public class MailMessageService : IMailMessageService
    {
        public MailMessage Get(EmailRequest emailRequest, EmailSettings emailSettings)
        {
            var message = new MailMessage();
            message.From = new MailAddress(emailSettings.Mail, emailSettings.DisplayName);
            message.To.Add(new MailAddress(emailRequest.To));
            message.Subject = emailRequest.Subject;
            message.IsBodyHtml = true;
            message.Body = null;
            return message;
        }
    }
}
