using API.Middlewares;
using API.ServiceExtension;
using Core;
using Core.Helpers;
using Hangfire;
using Hangfire.SqlServer;
using HangfireBasicAuthenticationFilter;
using Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using Core.Interfaces.CustomService;

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

            services.AddHttpClient();

            services.AddHangfire(configuration => configuration
                    .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                    .UseSimpleAssemblyNameTypeSerializer()
                    .UseRecommendedSerializerSettings()
                    .UseSqlServerStorage(
                        Configuration.GetConnectionString("DefaultConnection"),
                        new SqlServerStorageOptions
                        {
                            CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                            SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                            QueuePollInterval = TimeSpan.Zero,
                            UseRecommendedIsolationLevel = true,
                            DisableGlobalLocks = true
                        }));

            services.AddHangfireServer();
        }

        public void Configure(
            IApplicationBuilder app,
            IWebHostEnvironment env)
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

            app.UseStaticFiles();

            app.UseAuthorization();

            app.UseHangfireDashboard("/hangfire", new DashboardOptions
            {
                DashboardTitle = "Logistman",
                Authorization = new[]
                    {
                        new HangfireCustomBasicAuthenticationFilter{
                            User = Configuration.GetSection("HangfireSettings:UserName").Value,
                            Pass = Configuration.GetSection("HangfireSettings:Password").Value
                        }
                    }
            });

            app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapHangfireDashboard();
            });

            RecurringJob.AddOrUpdate<IHangFireService>(o => o.DeleteExpiredRoutesAsync(), Cron.Daily);
        }
    }
}
