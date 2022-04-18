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
        public static void AddIdentityCoreDbContext(this IServiceCollection services)
        {
            services.AddIdentityCore<User>().AddEntityFrameworkStores<ApplicationContext>();
        }
    }
}
