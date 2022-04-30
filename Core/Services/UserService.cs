using AutoMapper;
using Core.DTO.UserDTO;
using Core.Entities.UserEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Http;
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

        public async Task<UserProfileInfoDTO> GetUserProfileInfoAsync(HttpRequest request)
        {
            var userId = _jwtService.GetUserIdFromRequest(request);

            var user = await _userRepository.GetByIdAsync(userId);

            return _mapper.Map<UserProfileInfoDTO>(user);
        }
    }
}
