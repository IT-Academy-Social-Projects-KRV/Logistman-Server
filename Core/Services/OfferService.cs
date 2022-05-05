using System;
using AutoMapper;
using Core.DTO.OfferDTO;
using Core.Entities.OfferEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Threading.Tasks;
using Core.Entities.GoodCategoryEntity;
using Core.Entities.PointEntity;
using Core.Entities.RoleEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Microsoft.AspNetCore.Identity;

namespace Core.Services
{
    public class OfferService : IOfferService

    {
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly RoleManager<Role> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly IRepository<Point> _pointRepository;
        private readonly IRepository<GoodCategory> _goodCategoryRepository;
        public OfferService(
            IMapper mapper, 
            IRepository<Offer> offerRepository, 
            RoleManager<Role> roleManager,
            UserManager<User> userManager, 
            IRepository<Point> pointRepository,
            IRepository<GoodCategory> goodCategoryRepository
            )
        {
            _mapper = mapper;
            _offerRepository = offerRepository;
            _roleManager = roleManager;
            _userManager = userManager;
            _pointRepository = pointRepository;
            _goodCategoryRepository = goodCategoryRepository;
        }

        public async Task CreateOffer(OfferCreateDTO offerCreate)
        {
            var test = await _roleManager.FindByIdAsync(offerCreate.CreatorRoleId);
            ExceptionMethods.RoleNullCheck(
               await _roleManager.FindByIdAsync(offerCreate.CreatorRoleId));
            ExceptionMethods.UserNullCheck(
                await _userManager.FindByIdAsync(offerCreate.OfferCreatorId));
            ExceptionMethods.PointNullCheck(
                await _pointRepository.GetByIdAsync(offerCreate.OfferPointId));
            ExceptionMethods.GoodCategoryNullCheck(
                await _goodCategoryRepository.GetByIdAsync(offerCreate.GoodCategoryId));
            
            var offer = _mapper.Map<Offer>(offerCreate);

            offer.CreationDate = DateTimeOffset.UtcNow;
            offer.IsClosed = false;
           
            await _offerRepository.InsertAsync(offer);
            await _offerRepository.SaveChangesAsync();
        }
    }
}
