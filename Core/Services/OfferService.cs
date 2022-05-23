﻿using AutoMapper;
using Core.DTO.OfferDTO;
using Core.Entities.OfferEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Core.Specifications;

namespace Core.Services
{
    public class OfferService : IOfferService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Offer> _offerRepository;
        private readonly UserManager<User> _userManager;
        private readonly IGoodCategoryService _goodCategoryService;
        private readonly IOfferRoleService _offerRoleService;
        private readonly IPointService _pointService;
        private readonly ITripService _tripService;

        public OfferService(
            IMapper mapper,
            IRepository<Offer> offerRepository,
            UserManager<User> userManager,
            IGoodCategoryService goodCategoryService,
            IOfferRoleService offerRoleService,
            IPointService pointService,
            ITripService tripService)
        {
            _pointService = pointService;
            _offerRoleService = offerRoleService;
            _mapper = mapper;
            _offerRepository = offerRepository;
            _userManager = userManager;
            _goodCategoryService = goodCategoryService;
            _tripService = tripService;
        }

        public async Task CreateOfferAsync(OfferCreateDTO offerCreate, string userId)
        {
            if (offerCreate.Point.TripId != null)
            {
                var isTripExists = await _tripService.CheckIsTripExistsById((int)offerCreate.Point.TripId);

                if (!isTripExists)
                {
                    throw new HttpException(ErrorMessages.TripNotFound, HttpStatusCode.NotFound);
                }
            }

            ExceptionMethods.UserNullCheck(await _userManager.FindByIdAsync(userId));

            var offer = _mapper.Map<Offer>(offerCreate);
            offer.OfferCreatorId = userId;
            offer.CreationDate = DateTimeOffset.UtcNow;
            offer.IsClosed = false;
            offer.CreatorRoleId = await _offerRoleService.GetRoleByNameAsync(offerCreate.Role);
            offer.GoodCategoryId = await _goodCategoryService
                .GetGoodCategoryByNameAsync(offerCreate.GoodCategory);
            offer.OfferPointId = await _pointService.CreatePointForOfferAsync(offerCreate.Point);

            await _offerRepository.AddAsync(offer);
        }

        public async Task<OfferInfoDTO> GetOfferByIdAsync(int offerId, string userId)
        {
            var offer = await _offerRepository.GetBySpecAsync(new OfferSpecification.GetById(offerId, userId));

            ExceptionMethods.OfferNullCheck(offer);

            var offerInfo = _mapper.Map<OfferInfoDTO>(offer);

            return offerInfo;
        }

        public async Task<IList<OfferPreviewDTO>> GetUsersOffers(string userId)
        {
            var offersList = await _offerRepository.Query()
                .Where(o => o.OfferCreatorId == userId)
                .Include(offer => offer.Point)
                .Include(offer => offer.Role)
                .Include(offer => offer.GoodCategory)
                .ToListAsync();
            
            if (!offersList.Any())
            {
                return null;
            }
            return _mapper.ProjectTo<OfferPreviewDTO>(offersList.AsQueryable()).ToList();
        }
    }
}
