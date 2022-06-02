using Core.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ICarService
    {
        Task<CarDTO> AddCarAsync(CreateCarDTO createCarDTO, string userId);
        List<CarDTO> GetAllUserCars(string userId);
        Task<bool> CheckIsUserVerifiedByIdsAsync(int carId, string userId);
        List<CarDTO> GetVerifiedByUserId(string userId);
    }
}
