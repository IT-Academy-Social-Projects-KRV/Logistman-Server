using Core.DTO;
using Core.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ICarService
    {
        Task<CarDTO> AddCarAsync(CreateCarDTO createCarDTO, string userId);
        Task<PaginatedList<CarDTO>> GetAllUserCars(string userId, int pageNumber, int pageSize);
        Task<bool> CheckIsUserVerifiedByIdsAsync(int carId, string userId);
        List<CarDTO> GetVerifiedByUserId(string userId);
    }
}
