using Hospital.WebApi.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital.WebApi.Application.Config
{
    public static class ContextConfig
    {
        public static IServiceCollection GetContextConfig(this IServiceCollection services, 
                                                          IConfiguration configuration) => 
            services
                    .AddDbContext<ApplicationDbContext>(options => 
                     options
                        .UseSqlServer(configuration.GetConnectionString("Default")));

    }
}
