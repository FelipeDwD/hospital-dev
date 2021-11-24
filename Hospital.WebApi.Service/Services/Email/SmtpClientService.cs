using Hospital.WebApi.Domain.Interfaces.Services.Email;
using Hospital.WebApi.Domain.Models.Email;
using System.Net;
using System.Net.Mail;

namespace Hospital.WebApi.Service.Services.Email
{
    public class SmtpClientService : ISmtpClientService
    {
        public SmtpClient Get(EmailSettings emailSettings)
        {
            var smtp = new SmtpClient();
            smtp.Port = emailSettings.Port;
            smtp.Host = emailSettings.Host;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(emailSettings.Mail, emailSettings.Password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            return smtp;
        }
    }
}
