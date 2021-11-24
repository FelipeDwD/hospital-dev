using Hospital.WebApi.Domain.Interfaces.Services.Email;
using Hospital.WebApi.Domain.Models.Email;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Hospital.WebApi.Service.Services.Email
{
    public class MailService : IMailService
    {
        private readonly EmailSettings _mailSettings;

        public MailService(IOptions<EmailSettings> emailSettings) =>
            _mailSettings = emailSettings.Value;

        public async Task SendEmailAsync(EmailRequest emailRequest) =>
            await GetSmtpData()
                    .SendMailAsync(GetMessageData(emailRequest));        

        private MailMessage GetMessageData(EmailRequest emailRequest)
        {
            var message = new MailMessage();
            message.From = new MailAddress(_mailSettings.Mail, _mailSettings.DisplayName);
            message.To.Add(new MailAddress(emailRequest.To));
            message.Subject = emailRequest.Subject;
            message.IsBodyHtml = true;
            message.Body = null;
            return message;
        }

        private SmtpClient GetSmtpData()
        {
            var smtp = new SmtpClient();
            smtp.Port = _mailSettings.Port;
            smtp.Host = _mailSettings.Host;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(_mailSettings.Mail, _mailSettings.Password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            return smtp;
        }
    }
}
