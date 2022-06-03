using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO;
using Core.Entities.CarCategoryEntity;
using Core.Entities.CarEntity;
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
        private readonly IRepository<CarCategory> _categoryRepository;
        private readonly IMapper _mapper;

        public CarService(
            IRepository<Car> carRepository,
            IRepository<CarCategory> categoryRepository,
            IMapper mapper,
            UserManager<User> userManager)
        {
            _carRepository = carRepository;
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

        public async Task<PaginatedList<CarDTO>> GetAllUserCarsAsync(string userId, PaginationFilterDTO paginationFilter)
        {
            var userCars = await _carRepository.ListAsync(new CarSpecification.GetByUserId(userId));

            var paginatedUserCars = PaginatedList<Car>.Paginate(userCars, paginationFilter);

            if (paginatedUserCars == null)
            {
                return null;
            }

            return new PaginatedList<CarDTO>(
                _mapper.Map<List<CarDTO>>(paginatedUserCars.Items), 
                paginationFilter.PageNumber, 
                paginatedUserCars.TotalPages,
                paginatedUserCars.TotalItems);
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

        public async Task<PaginatedList<CarDTO>> GetVerifiedByUserIdAsync(string userId, PaginationFilterDTO paginationFilter)
        {
            var verifiedCars = await _carRepository
                .ListAsync(new CarSpecification.GetVerifiedByUserId(userId));

            var paginatedVerifiedCars = PaginatedList<Car>.Paginate(verifiedCars, paginationFilter);

            if (paginatedVerifiedCars == null)
            {
                return null;
            }

            return new PaginatedList<CarDTO>(
                _mapper.Map<List<CarDTO>>(paginatedVerifiedCars.Items),
                paginationFilter.PageNumber,
                paginatedVerifiedCars.TotalPages,
                paginatedVerifiedCars.TotalItems);
        }
    }
}
