using Core.DTO.CarDTO;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface ICarService
    {
        Task<CarDTO> AddCarAsync(CreateCarDTO createCarDTO, string userId);
        IQueryable<CarDTO> GetAllUserCars(string userId);
        bool CheckIsCarBelongsToUserByIds(int carId, string userId);
        bool CheckIsCarVerifiedById(int carId);
    }
}
