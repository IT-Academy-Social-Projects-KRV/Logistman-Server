using AutoMapper;
using Core.DTO;
using Core.Entities.GoodCategoryEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Linq;
using System.Threading.Tasks;
using Core.Exceptions;
using Core.Specifications;
using System.Collections.Generic;

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

        public async Task<List<GoodCategoryDTO>> GetAllGoodCategoryAsync()
        {
            var list = await _goodCategoryRepository.ListAsync();
            return _mapper.ProjectTo<GoodCategoryDTO>(list.AsQueryable()).ToList();
        }

        public async Task<int> GetGoodCategoryByNameAsync(string goodCategoryName)
        {
            var goodCategory = await _goodCategoryRepository
                .GetBySpecAsync(new GoodCategorySpecification.GetByName(goodCategoryName));

            ExceptionMethods.GoodCategoryNullCheck(goodCategory);

            return goodCategory.Id;
        }
    }
}
