using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO;
using Core.Entities.CarCategoryEntity;
using Core.Entities.CarEntity;
using Core.Entities.PointEntity;
using Core.Entities.TripEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using Microsoft.AspNetCore.Identity;

namespace Core.Services
{
    public class CarService : ICarService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Trip> _tripRepository;
        private readonly IRepository<PointData> _pointDataRepository;
        private readonly IRepository<CarCategory> _categoryRepository;
        private readonly IMapper _mapper;

        public CarService(
            IRepository<Car> carRepository,
            IRepository<Trip> tripRepository,
            IRepository<PointData> pointDataRepository,
            IRepository<CarCategory> categoryRepository,
            IMapper mapper,
            UserManager<User> userManager)
        {
            _carRepository = carRepository;
            _tripRepository = tripRepository;
            _pointDataRepository = pointDataRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<CarDTO> AddCarAsync(CreateCarDTO createCarDTO, string userId)
        {
            var car = _mapper.Map<Car>(createCarDTO);
            if (await IsCarExist(car))
            {
                throw new HttpException(ErrorMessages.AddingCarNotAllowed, HttpStatusCode.NotAcceptable);
            }

            car.CreationDate = DateTimeOffset.UtcNow;
            car.Category = await _categoryRepository.GetBySpecAsync(new CarCategorySpecification.GetByName(createCarDTO.CategoryName));

            var user = await _userManager.FindByIdAsync(userId);
            ExceptionMethods.UserNullCheck(user);
            car.User = user;
            car.User.HasCar = true;

            car = await _carRepository.AddAsync(car);
            return _mapper.Map<CarDTO>(car);
        }

        public async Task<PaginatedList<CarDTO>> GetAllUserCarsAsync(
            string userId, PaginationFilterDTO paginationFilter)
        {
            var userCarsCount = await _carRepository
                .CountAsync(new CarSpecification.GetByUserId(userId, paginationFilter));

            int totalPages = PaginatedList<CarDTO>.GetTotalPages(paginationFilter, userCarsCount);

            if (totalPages == 0)
            {
                return null;
            }

            var userCars = await _carRepository
                .ListAsync(
                new CarSpecification.GetByUserId(userId, paginationFilter));

            return PaginatedList<CarDTO>.Evaluate(
                _mapper.Map<List<CarDTO>>(userCars), paginationFilter.PageNumber, userCarsCount, totalPages);
        }

        private async Task<bool> IsCarExist(Car newCar)
        {
            return await _carRepository
                .AnyAsync(new CarSpecification.GetWithMainCredentials(
                    newCar.RegistrationNumber,
                    newCar.Vin,
                    newCar.TechnicalPassport));
        }

        public async Task<bool> CheckIsUserVerifiedByIdsAsync(int carId, string userId)
        {
            var car = await _carRepository.GetBySpecAsync(new CarSpecification.GetByIds(carId, userId));

            ExceptionMethods.CarNullCheck(car);

            return car.IsVerified;
        }

        public async Task<List<CarDTO>> GetVerifiedByUserIdAsync(string userId)
        {
            var verifiedCars = await _carRepository
                .ListAsync(new CarSpecification.GetVerifiedByUserId(userId));

            return _mapper.Map<List<CarDTO>>(verifiedCars);
        }

        public async Task VerifyAsync(VinDTO vinDTO)
        {
            var car = await _carRepository.GetBySpecAsync(
                new CarSpecification.GetWithVin(vinDTO.vin));
            ExceptionMethods.CarNullCheck(car);
            car.IsVerified = true;
            await _carRepository.UpdateAsync(car);
        }

        public async Task UnverifyAsync(VinDTO vinDTO)
        {
            var car = await _carRepository.GetBySpecAsync(
                new CarSpecification.GetWithVin(vinDTO.vin));
            ExceptionMethods.CarNullCheck(car);
            car.IsVerified = false;
            await _carRepository.UpdateAsync(car);
        }

        public async Task DeleteCarAsync(string userId, int carId)
        {
            var car = await _carRepository.GetBySpecAsync(
                new CarSpecification.GetWithTripsByIds(carId, userId));

            ExceptionMethods.CarNullCheck(car);

            if (car.Trips.Count == 0)
            {
                await _carRepository.DeleteAsync(car);
            }
            else
            {
                if (!await CheckCanCarBeDeletedAsync(car))
                {
                    throw new HttpException(
                        ErrorMessages.CarCantBeDeleted,
                        HttpStatusCode.Forbidden);
                }

                var routesWithCurrentCarToDelete = await _tripRepository
                    .ListAsync(new TripSpecification.GetRoutesWithoutRelatedOffersByCarId(car.Id));

                if (routesWithCurrentCarToDelete.Count != 0)
                {
                    var pointsToDelete = new List<PointData>();

                    foreach (var userRoute in routesWithCurrentCarToDelete)
                    {
                        pointsToDelete.AddRange(userRoute.Points);
                    }

                    await _tripRepository.DeleteRangeAsync(routesWithCurrentCarToDelete);
                    await _pointDataRepository.DeleteRangeAsync(pointsToDelete);
                }

                car.UserId = null;

                await _carRepository.UpdateAsync(car);
            }
        }

        private async Task<bool> CheckCanCarBeDeletedAsync(Car car)
        {
            var deletionBlockedByRoute = await _tripRepository
                .AnyAsync(new TripSpecification.GetActiveOrWithRelatedOffersByCarId(car.Id));

            if (deletionBlockedByRoute)
            {
                return false;
            }

            return true;
        }
    }
}
