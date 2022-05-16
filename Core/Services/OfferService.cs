using AutoMapper;
using Core.DTO.OfferDTO;
using Core.Entities.OfferEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly UserManager<User> _userManager;
        private readonly IGoodCategoryService _goodCategoryService;
        private readonly IRoleService _roleRepository;
        private readonly IPointService _pointService;

        public OfferService(
            IMapper mapper,
            IRepository<Offer> offerRepository,
            UserManager<User> userManager,
            IGoodCategoryService goodCategoryService,
            IRoleService roleRepository,
            IPointService pointService)
        {
            _pointService = pointService;
            _roleRepository = roleRepository;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _userManager = userManager;
            _goodCategoryService = goodCategoryService;
        }

        public async Task<OfferCreateDTO> CreateOfferAsync(OfferCreateDTO offerCreate, string userId)
        {
            ExceptionMethods.UserNullCheck(await _userManager.FindByIdAsync(userId));

            var offer = _mapper.Map<Offer>(offerCreate);
            offer.OfferCreatorId = userId;
            offer.CreationDate = DateTimeOffset.UtcNow;
            offer.IsClosed = false;
            offer.CreatorRoleId = await _roleRepository.GetRoleByNameAsync(offerCreate.Role);
            offer.GoodCategoryId = await _goodCategoryService
                .GetGoodCategoryByNameAsync(offerCreate.GoodCategory);
            offer.OfferPointId = await _pointService.CreatePointForOfferAsync(offerCreate.Point);

            await _offerRepository.AddAsync(offer);
            return _mapper.Map<OfferCreateDTO>(offerCreate);
        }
    }
}
