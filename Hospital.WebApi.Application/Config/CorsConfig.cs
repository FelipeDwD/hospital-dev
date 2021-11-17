using Microsoft.Extensions.DependencyInjection;

namespace Hospital.WebApi.Application.Config
{
    public static class CorsConfig
    {
        public static IServiceCollection GetConfigCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("Development",
                    builder =>
                    builder
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin());
            });     
    }
}
