using AutoMapper;
using Core.DTO.OfferDTO;
using Core.DTO.PointDTO;
using Core.Entities.GoodCategoryEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.RoleEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Microsoft.AspNetCore.Identity;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly UserManager<User> _userManager;
        private readonly IGoodCategoryService _goodCategoryService;
        private readonly IRoleService _roleService;
        private readonly IPointService _pointService;
        private readonly IRepository<Role> _roleRepository;
        private readonly IRepository<GoodCategory> _goodCategoryRepository;
        private readonly IRepository<Point> _pointRepository;

        public OfferService(
            IMapper mapper,
            IRepository<Offer> offerRepository,
            UserManager<User> userManager,
            IGoodCategoryService goodCategoryService,
            IRoleService roleService,
            IPointService pointService,
            IRepository<Role> roleRepository,
            IRepository<GoodCategory> goodCategoryRepository,
            IRepository<Point> pointRepository)
        {
            _pointService = pointService;
            _roleService = roleService;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _userManager = userManager;
            _goodCategoryService = goodCategoryService;
            _roleRepository = roleRepository;
            _goodCategoryRepository = goodCategoryRepository;
            _pointRepository = pointRepository;
        }

        public async Task<OfferCreateDTO> CreateOfferAsync(OfferCreateDTO offerCreate, string userId)
        {
            ExceptionMethods.UserNullCheck(await _userManager.FindByIdAsync(userId));

            var offer = _mapper.Map<Offer>(offerCreate);
            offer.OfferCreatorId = userId;
            offer.CreationDate = DateTimeOffset.UtcNow;
            offer.IsClosed = false;
            offer.CreatorRoleId = _roleService.GetRoleByName(offerCreate.Role);
            offer.GoodCategoryId = _goodCategoryService
                .GetGoodCategoryByName(offerCreate.GoodCategory);
            offer.OfferPointId = await _pointService.CreatePointForOfferAsync(offerCreate.Point);

            await _offerRepository.InsertAsync(offer);
            await _offerRepository.SaveChangesAsync();
            return _mapper.Map<OfferCreateDTO>(offerCreate);
        }

        public async Task<OfferInfoDTO> GetConcreteOfferAsync(int offerId, string userId)
        {
            var offer = await _offerRepository.GetByIdAsync(offerId);

            ExceptionMethods.OfferNullCheck(offer);
            ExceptionMethods.UserNullCheck(await _userManager.FindByIdAsync(userId));

            if (offer.OfferCreatorId != userId)
            {
                throw new HttpException(ErrorMessages.OfferNotFound, HttpStatusCode.NotFound);
            }

            var offerInfo = _mapper.Map<OfferInfoDTO>(offer);
            offerInfo.Role = (await _roleRepository.GetByIdAsync(offer.CreatorRoleId)).Name;
            offerInfo.GoodCategory = (await _goodCategoryRepository.
                GetByIdAsync(offer.GoodCategoryId)).Name;
            var point = await _pointRepository.GetByIdAsync(offer.OfferPointId);

            ExceptionMethods.PointNullCheck(point);

            offerInfo.Point = _mapper.Map<PointInfoDTO>(point);

            return offerInfo;
        }
    }
}
