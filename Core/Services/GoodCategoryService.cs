using AutoMapper;
using Core.DTO.GoodCategoryDTO;
using Core.Entities.GoodCategoryEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Linq;
using System.Threading.Tasks;
using Core.Exceptions;
using Core.Specifications;

namespace Core.Services
{
    public class GoodCategoryService : IGoodCategoryService
    {
        private readonly IRepository<GoodCategory> _goodCategoryRepository;
        private readonly IMapper _mapper;

        public GoodCategoryService(
            IRepository<GoodCategory> goodCategoryRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _goodCategoryRepository = goodCategoryRepository;
        }

        public async Task<GoodCategoryListDTO> GetAllGoodCategoryAsync()
        {
            var list = await _goodCategoryRepository.GetAllAsync();
            return new GoodCategoryListDTO
                {GoodCategories = _mapper.ProjectTo<GoodCategoryDTO>(list.AsQueryable())};
        }

        public async Task<int> GetGoodCategoryByNameAsync(string goodCategoryName)
        {
<<<<<<< HEAD
            var goodCategory = (await _goodCategoryRepository
                .FindWithSpecificationAsync(new GetGoodCategoryByName(goodCategoryName)))
=======
            var goodCategory =  _goodCategoryRepository
                .FindWithSpecification(new GetGoodCategoryByName(goodCategoryName))
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace
                .First();

            ExceptionMethods.GoodCategoryNullCheck(goodCategory);

            return goodCategory.Id;
        }
    }
}
