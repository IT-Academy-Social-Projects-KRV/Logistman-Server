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
        private readonly IGoodCategoryService _goodCategoryRepository;
        private readonly IRoleService _roleRepository;
        private readonly IPointService _pointService;
        public OfferService(
            IMapper mapper, 
            IRepository<Offer> offerRepository,
            UserManager<User> userManager,
            IGoodCategoryService goodCategoryRepository,
            IRoleService roleRepository,
            IPointService pointService)
        {
            _pointService = pointService;
            _roleRepository = roleRepository;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _userManager = userManager;
            _goodCategoryRepository = goodCategoryRepository;
        }
        public async Task<OfferCreateDTO> CreateOfferAsync(OfferCreateDTO offerCreate, string userId)
        {
            ExceptionMethods.UserNullCheck(await _userManager.FindByIdAsync(userId));

            var offer = _mapper.Map<Offer>(offerCreate);
            offer.OfferCreatorId = userId;
            offer.CreationDate = DateTimeOffset.UtcNow;
            offer.OfferPointId = await _pointService.CreatePointForOfferAsync(offerCreate.Point);
            offer.IsClosed = false;
            offer.CreatorRoleId = _roleRepository.GetRoleByName(offerCreate.Role);
            offer.GoodCategoryId = _goodCategoryRepository
                .GetGoodCategoryByName(offerCreate.GoodCategory);

            await _offerRepository.InsertAsync(offer);
            await _offerRepository.SaveChangesAsync();
            return _mapper.Map<OfferCreateDTO>(offerCreate);
        }
    }
}
