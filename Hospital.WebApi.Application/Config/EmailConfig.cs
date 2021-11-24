using Hospital.WebApi.Domain.Models.Email;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital.WebApi.Application.Config
{
    public static class EmailConfig
    {
        public static IServiceCollection GetEmailConfig(this IServiceCollection services, IConfiguration configuration) =>
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));        
    }
}
