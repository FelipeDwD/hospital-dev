using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Interfaces.Services.Validations;
using Hospital.WebApi.Infra.Data.Repository;
using Hospital.WebApi.Service.Services;
using Hospital.WebApi.Service.Services.Validations;
using Hospital.WebApi.Service.Validations;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital.WebApi.Application.Config
{
    public static class InjectionMapConfig
    {
        public static IServiceCollection GetInjection(this IServiceCollection services) =>
                services
                    .GetInjectionValidations()
                    .GetInjectionServices()
                    .GetInjectionRepositories();

        private static IServiceCollection GetInjectionValidations(this IServiceCollection services) =>
            services
                .AddScoped<UserValidation>()
                .AddScoped<ContactValidation>()
                .AddScoped<IUserValidationService, UserValidationService>()
                .AddScoped<IContactValidationService, ContactValidationService>();

        private static IServiceCollection GetInjectionServices(this IServiceCollection services) =>
            services
             .AddScoped<IUserService, UserService>()
             .AddScoped<ILoginService, LoginService>()
             .AddScoped<IContactService, ContactService>();

        private static IServiceCollection GetInjectionRepositories(this IServiceCollection services) =>
            services
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<ILoginRepository, LoginRepository>()
            .AddScoped<IContactRepository, ContactRepository>();        
    }
}
