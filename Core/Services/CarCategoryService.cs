using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO.CarCategoryDTO;
using Core.Entities.CarCategoryEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;

namespace Core.Services
{
    public class CarCategoryService : ICarCategoryService
    {
        private readonly IRepository<CarCategory> _carCategoryRepository;
        private readonly IMapper _mapper;
        public CarCategoryService(
            IRepository<CarCategory> carCategoryRepository,
            IMapper mapper)
        {
            _carCategoryRepository = carCategoryRepository;
            _mapper = mapper;
        }
        
        public async Task<CarCategoriesListDTO> GetAllCarCategoriesAsync()
        {
            var list = await _carCategoryRepository.GetAllAsync();
            return new CarCategoriesListDTO
                {CarCategories = _mapper.ProjectTo<CarCategoryDTO>(list.AsQueryable())};
        }
    }
}
