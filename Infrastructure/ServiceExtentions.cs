using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceExtentions
    {
        public static void AddDbContext(this IServiceCollection service, string connectionString)
        {
            service.AddDbContext<ApplicationContext>(options => options.UseSqlServer(connectionString));
        }
    }
}
