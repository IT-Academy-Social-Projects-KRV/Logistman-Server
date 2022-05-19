using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO.CarCategoryDTO;
using Core.Entities.CarCategoryEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;

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
            var carCategories = await _carCategoryRepository.ListAsync();
            if (!carCategories.Any())
            {
                throw new HttpException(ErrorMessages.CarCategoryNotFound, HttpStatusCode.NotFound);
            }
            
            return new CarCategoriesListDTO
            {
                CarCategories = _mapper.ProjectTo<CarCategoryDTO>(carCategories.AsQueryable())
            };
        }
    }
}
