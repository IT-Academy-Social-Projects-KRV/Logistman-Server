﻿using System;
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
            if (await IsCarExist(car))
                throw new HttpException(ErrorMessages.AddingCarNotAllowed, HttpStatusCode.NotAcceptable);

            car.CreationDate = DateTimeOffset.UtcNow;
            car.Category = await _categoryRepository.GetByIdAsync(createCarDTO.CategoryId);

            var user = await _userManager.FindByIdAsync(userId);
            car.User = user ?? throw new HttpException(ErrorMessages.UserNotFound, HttpStatusCode.NotFound);
            car.User.HasCar = true;

            car = await _carRepository.InsertAsync(car);
            await _carRepository.SaveChangesAsync();
            return _mapper.Map<CarDTO>(car);
        }

        public IQueryable<CarDTO> GetAllUserCars(string userId)
        {
            var userCars = _carRepository.Query()
                                         .Where(c => c.UserId == userId)
                                         .Include(c => c.Category);

            return _mapper.ProjectTo<CarDTO>(userCars);
        }

        public bool CheckIsCarExistsById(int carId)
        {
            return _carRepository.Query()
                                 .Any(c => c.Id == carId);
        }

        private async Task<bool> IsCarExist(Car newCar)
        {
            var carsList = await _carRepository.GetAllAsync();
            foreach (var car in carsList)
            {
                if (car.RegistrationNumber.Equals(newCar.RegistrationNumber))
                {
                    return true;
                }
                if (car.Vin.Equals(newCar.Vin))
                {
                    return true;
                }
                if (car.TechnicalPassport.Equals(newCar.TechnicalPassport))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
