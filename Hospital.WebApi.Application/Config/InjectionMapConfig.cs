using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Interfaces.Services.Email;
using Hospital.WebApi.Domain.Interfaces.Services.Validations;
using Hospital.WebApi.Infra.Data.Repository;
using Hospital.WebApi.Service.Services;
using Hospital.WebApi.Service.Services.Email;
using Hospital.WebApi.Service.Services.Validations;
using Hospital.WebApi.Service.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital.WebApi.Application.Config
{
    public static class InjectionMapConfig
    {
        public static IServiceCollection GetInjectionConfig(this IServiceCollection services) =>
                services                                        
                    .GetValidationsConfig()
                    .GetServicesConfig()
                    .GetRepositoriesConfig();               


        private static IServiceCollection GetValidationsConfig(this IServiceCollection services) =>
            services
                .AddScoped<UserValidation>()
                .AddScoped<ContactValidation>();                

        private static IServiceCollection GetServicesConfig(this IServiceCollection services) =>
            services
             .AddScoped<IUserService, UserService>()
             .AddScoped<ILoginService, LoginService>()
             .AddScoped<IContactService, ContactService>()
             .AddScoped<IMailService, MailService>()
             .AddScoped<IMailMessageService, MailMessageService>()
             .AddScoped<ISmtpClientService, SmtpClientService>()
             .AddScoped<IUserValidationService, UserValidationService>()
             .AddScoped<IContactValidationService, ContactValidationService>()
             .AddScoped<ITokenService, TokenService>()
             .AddScoped<ITokenDescriptorService, TokenDescriptorService>()
             .AddScoped<IClaimService, ClaimService>()
             .AddScoped<IDddService, DddService>();

        private static IServiceCollection GetRepositoriesConfig(this IServiceCollection services) =>
            services
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<ILoginRepository, LoginRepository>()
            .AddScoped<IContactRepository, ContactRepository>();        
    }
}
