using Microsoft.Extensions.DependencyInjection;

namespace Hospital.WebApi.Application.Config
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection GetAutoMapperConfig(this IServiceCollection services) =>
            services.AddAutoMapper(typeof(Startup));        
    }
}
