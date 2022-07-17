using AutoMapper;
using Core.DTO;
using Core.Constants;
using Core.Entities.UserEntity;
using Core.Exceptions;
using Core.Helpers;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Collections.Generic;
using Core.Entities.CarEntity;
using Core.Entities.InviteEntity;
using Core.Entities.TripEntity;
using Core.Entities.OfferEntity;
using Core.Entities.PointEntity;
using Core.Entities.NotificationEntity;

namespace Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<IdentityUserRole<string>> _userRoleRepository;
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Trip> _tripRepository;
        private readonly IRepository<Invite> _inviteRepository;
        private readonly IRepository<Offer> _offerRepository;
        private readonly IRepository<PointData> _pointDataRepository;
        private readonly IRepository<Notification> _notificationRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;

        public UserService(
            IRepository<User> userRepository,
            IRepository<IdentityUserRole<string>> userRoleRepository,
            IRepository<Car> carRepository,
            IRepository<Trip> tripRepository,
            IRepository<Invite> inviteRepository,
            IRepository<Offer> offerRepository,
            IRepository<PointData> pointDataRepository,
            IRepository<Notification> notificationRepository,
            IMapper mapper,
            UserManager<User> userManager,
            RoleManager<IdentityRole> roleManager,
            IEmailService emailService)
        {
            _userRepository = userRepository;
            _userRoleRepository = userRoleRepository;
            _carRepository = carRepository;
            _tripRepository = tripRepository;
            _inviteRepository = inviteRepository;
            _offerRepository = offerRepository;
            _pointDataRepository = pointDataRepository;
            _notificationRepository = notificationRepository;
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _emailService = emailService;
        }

        public string GetCurrentUserNameIdentifier(ClaimsPrincipal currentUser)
        {
            return currentUser.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public async Task<UserProfileInfoDTO> GetUserProfileInfoAsync(string userId)
        {
            var user = await _userRepository.GetByIdAsync(userId);

            ExceptionMethods.UserNullCheck(user);

            return _mapper.Map<UserProfileInfoDTO>(user);
        }

        public async Task<string> GetUserRoleAsync(User user)
        {
            var userRoles = await _userManager.GetRolesAsync(user);

            if (userRoles == null)
            {
                throw new HttpException(ErrorMessages.RoleNotFound, HttpStatusCode.NotFound);
            }

            return userRoles.First(); // we get only the first role, because the user will have only one
        }

        public async Task UserEditProfileInfoAsync(UserEditProfileInfoDTO userEditProfileInfo, string userId, string callbackUrl)
        {
            var updateUser = await _userRepository.GetByIdAsync(userId);

            ExceptionMethods.UserNullCheck(updateUser);

            updateUser.Name = userEditProfileInfo.Name;
            updateUser.Surname = userEditProfileInfo.Surname;

            if (!userEditProfileInfo.Email.Equals(updateUser.Email))
            {
                if (await _userRepository.AnyAsync(new UserSpecification.GetByEmail(userEditProfileInfo.Email)))
                {
                    throw new HttpException(ErrorMessages.FailedSendEmail, HttpStatusCode.BadRequest);
                }

                updateUser.Email = userEditProfileInfo.Email;
                updateUser.UserName = userEditProfileInfo.Email;
                updateUser.NormalizedEmail = userEditProfileInfo.Email.ToUpper();
                updateUser.NormalizedUserName = userEditProfileInfo.Email.ToUpper();
                updateUser.EmailConfirmed = false;
                
                await _emailService.SendConfirmationEmailAsync(updateUser, callbackUrl);
            }

            await _userRepository.UpdateAsync(updateUser);
        }

        public async Task<UserFullNameDTO> GetUserFullNameAsync(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            ExceptionMethods.UserNullCheck(user);

            return _mapper.Map<UserFullNameDTO>(user);
        }

        public async Task<PaginatedList<UserDTO>> GetAllUsersAsync(PaginationFilterDTO paginationFilter)
        {
            var roleId = (await _roleManager.FindByNameAsync(IdentityRoleNames.User.ToString())).Id;

            var userRolesCount = await _userRoleRepository
                .CountAsync(new IdentityUserRoleSpecification.GetUserRoleByRoleId(roleId, paginationFilter));

            int totalPages = PaginatedList<UserDTO>.GetTotalPages(paginationFilter, userRolesCount);

            if (totalPages == 0)
            {
                return null;
            }

            var userRoles = await _userRoleRepository
                .ListAsync(
                new IdentityUserRoleSpecification
                .GetUserRoleByRoleId(roleId, paginationFilter));

            List<string> userIds = new List<string>();

            foreach(var userRole in userRoles)
            {
                userIds.Add(userRole.UserId);
            }

            var userList = await _userRepository
                .ListAsync(new UserSpecification.GetByIds(userIds));

            return PaginatedList<UserDTO>
                .Evaluate(_mapper.Map<List<UserDTO>>(userList), paginationFilter.PageNumber, userRolesCount, totalPages);
        }

        public async Task<string> GetUserIdByEmailAsync(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            ExceptionMethods.UserNullCheck(user);

            return user.Id;
        }

        public async Task DeleteUserAsync(string userId)
        {
            var user = await _userRepository.GetBySpecAsync(new UserSpecification.GetById(userId));

            ExceptionMethods.UserNullCheck(user);

            var userCanBeDeleted = await CheckCanUserBeDeletedAsync(user);

            if (!userCanBeDeleted)
            {
                throw new HttpException(
                    ErrorMessages.UserCantBeDeleted,
                    HttpStatusCode.Forbidden);
            }

            var userOffersToDelete = await _offerRepository
                .ListAsync(new OfferSpecification.GetOpenByUserId(userId));
            var userTripsToDelete = await _tripRepository
                .ListAsync(new TripSpecification.GetRoutesByUserId(userId));
            var pointsToDelete = new List<PointData>();
            var userCarsToDelete = new List<Car>();

            foreach (var userTrip in userTripsToDelete)
            {
                pointsToDelete.AddRange(userTrip.Points);
            }

            foreach (var userOffer in userOffersToDelete)
            {
                pointsToDelete.Add(userOffer.Point);
            }

            await _inviteRepository.DeleteRangeAsync(user.Invites);
            await _notificationRepository.DeleteRangeAsync(user.Notifications);
            await _tripRepository.DeleteRangeAsync(userTripsToDelete);
            await _offerRepository.DeleteRangeAsync(userOffersToDelete);
            await _pointDataRepository.DeleteRangeAsync(pointsToDelete);

            var userCars = await _carRepository
                .ListAsync(new CarSpecification.GetWithTripsByUserId(userId));

            foreach (var userCar in userCars)
            {
                if (userCar.Trips.Count == 0)
                {
                    userCarsToDelete.Add(userCar);
                }
            }

            await _carRepository.DeleteRangeAsync(userCarsToDelete);
            await _userRepository.DeleteAsync(user);
        }

        private async Task<bool> CheckCanUserBeDeletedAsync(User user)
        {
            var userHasActiveTrip = await _tripRepository
                .AnyAsync(new TripSpecification.GetActiveByUserId(user.Id));
            
            if (userHasActiveTrip)
            {
                return false;
            }

            foreach (var offer in user.Offers)
            {
                if (offer.RelatedTripId != null)
                {
                    var userHasActiveOffer = await _tripRepository
                        .AnyAsync(new TripSpecification.GetActiveById((int)offer.RelatedTripId));
                    
                    if (userHasActiveOffer)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
