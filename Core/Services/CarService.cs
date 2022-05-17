using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTO.CarDTO;
using Core.Entities.CarCategoryEntity;
using Core.Entities.CarEntity;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
            if (IsCarExist(car))
            {
                throw new HttpException(ErrorMessages.AddingCarNotAllowed, HttpStatusCode.NotAcceptable);
            }

            car.CreationDate = DateTimeOffset.UtcNow;
            car.Category = _categoryRepository.Query().First(c => c.Name == createCarDTO.CategoryName);

            var user = await _userManager.FindByIdAsync(userId);
            ExceptionMethods.UserNullCheck(user);
            car.User = user;
            car.User.HasCar = true;

            car = await _carRepository.AddAsync(car);
            return _mapper.Map<CarDTO>(car);
        }

        public IQueryable<CarDTO> GetAllUserCars(string userId)
        {
            var userCars = _carRepository.Query()
                                         .Where(c => c.UserId == userId)
                                         .Include(c => c.Category);

            return _mapper.ProjectTo<CarDTO>(userCars);
        }

        private bool IsCarExist(Car newCar)
        {
            return await _carRepository
                .AnyAsync(new GetCarWithMainCredentials(
                    newCar.RegistrationNumber,
                    newCar.Vin,
                    newCar.TechnicalPassport));;
        }
    }
}
