using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Hospital.WebApi.Application.Config
{
    public static class SwaggerConfig
    {
        public static IServiceCollection GetSwaggerConfig(this IServiceCollection services) =>
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc(name: "v1", new OpenApiInfo { Title = "Hospital API", Version = "v1" });
            });

        public static IApplicationBuilder GetUseSwaggerUI(this IApplicationBuilder app) =>
            app.UseSwaggerUI(x =>
            {
                x.SwaggerEndpoint(url: "/swagger/v1/swagger.json", name: "v1");
            });
    }
}
