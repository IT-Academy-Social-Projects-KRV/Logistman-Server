using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO;

namespace Core.Interfaces.CustomService
{
    public interface IPointService
    {
        Task<int> CreateAsync(PointDTO pointDTO);
        List<PointDTO> SortByOrder(List<PointDTO> points);
        Task SetTripIdToListAsync(List<PointDTO> points, int tripId);
    }
}
