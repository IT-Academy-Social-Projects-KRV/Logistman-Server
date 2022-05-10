using AutoMapper;
using Core.DTO.OfferDTO;
using Core.Entities.GoodCategoryEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.RoleEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class OfferService : IOfferService

    {
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly UserManager<User> _userManager;
        private readonly IRepository<Point> _pointRepository;
        private readonly IRepository<GoodCategory> _goodCategoryRepository;
        private readonly IRepository<Role> _roleRepository;
        public OfferService(
            IMapper mapper, 
            IRepository<Offer> offerRepository,
            UserManager<User> userManager, 
            IRepository<Point> pointRepository,
            IRepository<GoodCategory> goodCategoryRepository,
            IRepository<Role> roleRepository
        )
        {
            _roleRepository = roleRepository;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _userManager = userManager;
            _pointRepository = pointRepository;
            _goodCategoryRepository = goodCategoryRepository;
        }

        public async Task<OfferCreateDTO> CreateOffer(OfferCreateDTO offerCreate, string userId)
        {
            ExceptionMethods.UserNullCheck(
                await _userManager.FindByIdAsync(userId));
            ExceptionMethods.GoodCategoryNullCheck(
                await _goodCategoryRepository.GetByIdAsync(offerCreate.GoodCategoryId));

            var roles = await _roleRepository.GetAllAsync();
            var role = roles.FirstOrDefault(role => role.Name == offerCreate.Role.ToUpper());
            if (role == null)
            {
                throw new HttpException("Role not found", HttpStatusCode.BadRequest);
            }

            var point = _mapper.Map<Point>(offerCreate.Point);
            await _pointRepository.InsertAsync(point);
            await _pointRepository.SaveChangesAsync();

            var offer = _mapper.Map<Offer>(offerCreate);
            offer.OfferCreatorId = userId;
            offer.CreationDate = DateTimeOffset.UtcNow;
            offer.OfferPointId = point.Id;
            offer.IsClosed = false;
            offer.Role = role;
           
            await _offerRepository.InsertAsync(offer);
            await _offerRepository.SaveChangesAsync();
            return _mapper.Map<OfferCreateDTO>(offerCreate);
        }
    }
}
