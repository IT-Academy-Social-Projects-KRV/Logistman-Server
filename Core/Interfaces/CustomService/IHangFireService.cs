using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IHangFireService
    {
        Task DeleteExpiredRoutesAsync();
        Task ActivatePossibleTripsAsync();
    }
}
