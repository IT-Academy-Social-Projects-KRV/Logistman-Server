using System.Threading.Tasks;
using Core.DTO.PointDTO;

namespace Core.Interfaces.CustomService
{
    public interface IPointService
    {
        Task<int> CreatePointForOfferAsync(PointInfoDTO offerCreate);
    }
}
