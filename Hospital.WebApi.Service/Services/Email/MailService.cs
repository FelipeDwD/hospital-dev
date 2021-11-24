using Hospital.WebApi.Domain.Interfaces.Services.Email;
using Hospital.WebApi.Domain.Models.Email;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Hospital.WebApi.Service.Services.Email
{
    public class MailService : IMailService
    {
        private readonly EmailSettings _mailSettings;
        private readonly IMailMessageService _mailMessageService;
        private readonly ISmtpClientService _smtpClientService;

        public MailService(IOptions<EmailSettings> emailSettings,
                           IMailMessageService mailMessageService,
                           ISmtpClientService smtpClientService)
        {
            _mailSettings = emailSettings.Value;
            _mailMessageService = mailMessageService;
            _smtpClientService = smtpClientService;
        }            

        public async Task SendEmailAsync(EmailRequest emailRequest)
        {
            var message = _mailMessageService.Get(emailRequest, _mailSettings);
            var smtp = _smtpClientService.Get(_mailSettings);
            await smtp.SendMailAsync(message);
        }                  
    }
}
