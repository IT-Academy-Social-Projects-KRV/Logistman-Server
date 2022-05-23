using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IOfferRoleService
    {
        Task<int> GetRoleByNameAsync(string name);
    }
}
