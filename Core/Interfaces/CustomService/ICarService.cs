using System.Threading.Tasks;
using Core.DTO.CarDTO;
using Core.Entities.CarEntity;

namespace Core.Interfaces.CustomService
{
    public interface ICarService
    {
        Task<CarDTO> AddCarAsync(CreateCarDTO createCarDTO, string userId);
    }
}
