using API.Middlewares;
using API.ServiceExtension;
using Core;
using Core.Helpers;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddRepositories();

            services.AddDbContext(Configuration.GetConnectionString("DefaultConnection"));

            services.AddIdentityDbContext();

            services.AddAuthentication();

            services.AddCustomServices();

            services.Configures(Configuration.GetSection(nameof(AppSettings)));

            services.AddFluentValidation();

            services.AddAutoMapper();

            services.AddResponseCaching();

            services.ConfigJwtOptions(Configuration);

            services.AddJwtAuthentication(Configuration);

            services.AddMvcCore().AddRazorViewEngine();

            services.AddSwagger();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseAuthentication();

            app.UseMiddleware<ExceptionHandlerMiddleware>();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
