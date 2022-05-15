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
            var list = await _goodCategoryRepository.ListAsync();
            return new GoodCategoryListDTO
                {GoodCategories = _mapper.ProjectTo<GoodCategoryDTO>(list.AsQueryable())};
        }

        public async Task<int> GetGoodCategoryByNameAsync(string goodCategoryName)
        {
            var goodCategory = await _goodCategoryRepository
                .GetBySpecAsync(new GetGoodCategoryByName(goodCategoryName));

            ExceptionMethods.GoodCategoryNullCheck(goodCategory);

            return goodCategory.Id;
        }
    }
}
