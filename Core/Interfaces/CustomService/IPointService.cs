using System.Collections.Generic;
using System.Threading.Tasks;
using Core.DTO;
using Core.Entities.PointEntity;

namespace Core.Interfaces.CustomService
{
    public interface IPointService
    {
        Task<PointData> CreateAsync(PointDTO pointDTO);
        List<PointDTO> SortByOrder(List<PointDTO> points);
        List<PointsTripDTO> SortByOrder(List<PointsTripDTO> points);
        Task SetTripIdToListAsync(List<PointDTO> points, int tripId);
    }
}
