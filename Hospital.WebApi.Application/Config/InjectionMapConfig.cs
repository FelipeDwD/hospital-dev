using Hospital.WebApi.Domain.Interfaces.Services.Validations;
using Hospital.WebApi.Service.Services.Validations;
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
        

        private static IServiceCollection GetInjectionValidations(this IServiceCollection services)
        {
            services.AddScoped<IUserValidationService, UserValidationService>();
            services.AddScoped<IContactValidationService, ContactValidationService>();
            return services;
        }

        private static IServiceCollection GetInjectionServices(this IServiceCollection services)
        {
            return services;
        }

        private static IServiceCollection GetInjectionRepositories(this IServiceCollection services)
        {
           return services;
        }
    }
}
