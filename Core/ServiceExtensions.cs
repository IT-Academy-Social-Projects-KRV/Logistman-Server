using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using Core.Helpers;
using Core.Interfaces.CustomService;
using Core.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class ServiceExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IJwtService, JwtService>();
        }
        
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var configures = new MapperConfiguration(mc =>
            {
                mc.CreateMap<User, UserRegistrationDTO>().ReverseMap();
                mc.CreateMap<User, UserRegistrationDTO>().ReverseMap()
                    .ForMember(dest => dest.UserName, 
                    act => act.MapFrom(src => src.Email));
            });

            IMapper mapper = configures.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void ConfigJwtOptions(this IServiceCollection services, IConfiguration config)
        {

            services.Configure<JwtOptions>(config.GetSection("JwtOptions"));

        }

    }
}
