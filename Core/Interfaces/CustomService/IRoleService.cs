using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IRoleService
    {
        int GetRoleByName(string name);
    }
}
