﻿using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly IJwtService _jwtService;
        private readonly IRepository<User> _userRepository;
        private readonly IMapper _mapper;

        public UserService(
            IJwtService jwtService,
            IRepository<User> userRepository,
            IMapper mapper)
        {
            _jwtService = jwtService;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser)
        {
            return currentUser.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public async Task<UserProfileInfoDTO> GetUserProfileInfoAsync(string userId)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new HttpException(ErrorMessages.UserIdNotFound, System.Net.HttpStatusCode.NotFound);
            }

            var user = await _userRepository.GetByIdAsync(userId);

            return _mapper.Map<UserProfileInfoDTO>(user);
        }
    }
}
