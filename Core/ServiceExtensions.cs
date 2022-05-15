using AutoMapper;
using Core.Helpers;
using Core.Helpers.ApplicationProfiles;
using Core.Interfaces.CustomService;
using Core.Services;
using Core.Validation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IJwtService, JwtService>();
            services.AddScoped<IOfferService, OfferService>();
            services.AddScoped<IPointService, PointService>();
            services.AddScoped<IGoodCategoryService, GoodCategoryService>();
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<ITripService, TripService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configures = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new UserProfiles());
                mc.AddProfile(new OfferProfiles());
                mc.AddProfile(new PointProfiles());
                mc.AddProfile(new GoodCategoryProfiles());
                mc.AddProfile(new CarProfile());
                mc.AddProfile(new TripProfile());
            });

            var mapper = configures.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void AddFluentValidation(this IServiceCollection services)
        {
            services.AddFluentValidation(c => c.RegisterValidatorsFromAssemblyContaining<UserRegistrationValidation>());
        }

        public static void ConfigJwtOptions(this IServiceCollection services, IConfiguration config)
        {
            services.Configure<JwtOptions>(config.GetSection("JwtOptions"));
            services.Configure<RolesOptions>(config.GetSection("RolesOptions"));
        }
    }
}
