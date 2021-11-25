using Hospital.WebApi.Application.Config;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace Hospital.WebApi.Application
{
    public class Startup
    {

        public IConfiguration _configuration { get; }
        
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{hostingEnvironment.EnvironmentName}.json", true, true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();            
        }       

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.GetCorsConfig();
            services.GetContextConfig(_configuration);
            services.GetInjectionConfig();
            services.GetEmailConfig(_configuration);
            services.GetSwaggerConfig();
            var key = _configuration.GetValue<string>("Jwt:Secret");
            var securityKey = Encoding.ASCII.GetBytes(key);
            services.GetJwtConfig(securityKey);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.GetUseSwaggerUI();
        }
    }
}
