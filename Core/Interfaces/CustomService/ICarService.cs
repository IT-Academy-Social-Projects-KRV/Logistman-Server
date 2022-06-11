using Core.DTO;
using Core.Helpers;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ICarService
    {
        Task<CarDTO> AddCarAsync(CreateCarDTO createCarDTO, string userId);
        Task<PaginatedList<CarDTO>> GetAllUserCarsAsync(string userId, PaginationFilterDTO paginationFilter);
        Task<bool> CheckIsUserVerifiedByIdsAsync(int carId, string userId);
        Task<List<CarDTO>> GetVerifiedByUserIdAsync(string userId);
    }
}
