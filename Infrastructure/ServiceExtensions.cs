using Core.Entities.RoleEntity;
using Core.Entities.UserEntity;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceExtensions
    {
        public static void AddDbContext(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
        }
        public static void AddIdentityDbContext(this IServiceCollection service)
        {
            service.AddIdentity<User, Role>().AddEntityFrameworkStores<ApplicationContext>().AddDefaultTokenProviders();
        }
    }
}
