using System.Threading.Tasks;
using Core.DTO;

namespace Core.Interfaces.CustomService
{
    public interface IPointService
    {
        Task<int> CreatePointForOfferAsync(PointDTO offerCreate);
    }
}
