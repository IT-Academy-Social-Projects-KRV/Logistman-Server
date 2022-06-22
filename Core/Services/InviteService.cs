using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Threading.Tasks;
using Core.Entities.InviteEntity;
using Core.DTO.InviteDTO;
using System.Collections.Generic;
using Core.Entities.OfferEntity;
using Core.Exceptions;
using Core.Specifications;
using System.Linq;
using Core.Entities.TripEntity;

namespace Core.Services
{
    public class InviteService : IInviteService
    {
        private readonly IRepository<Invite> _inviteRepository;
        private readonly IRepository<Trip> _tripRepository;
        private readonly IRepository<Offer> _offerRepository;

        public InviteService(
            IRepository<Invite> inviteRepository,
            IRepository<Trip> tripRepository,
            IRepository<Offer> offerRepository)
        {
            _inviteRepository = inviteRepository;
            _tripRepository = tripRepository;
            _offerRepository = offerRepository;
        }

        public async Task CreateTripInvitesAsync(CreateTripInvitesDTO createTripInvitesDTO)
        {
            var trip = await _tripRepository.GetByIdAsync(createTripInvitesDTO.TripId);

            ExceptionMethods.TripNullCheck(trip);

            var previousTripInvites = await _inviteRepository.ListAsync(
                new InviteSpecification.GetByTripId(createTripInvitesDTO.TripId));
            var newInvites = new List<Invite>();

            createTripInvitesDTO.OffersId = createTripInvitesDTO.OffersId.Distinct().ToList();

            foreach (var offerId in createTripInvitesDTO.OffersId)
            {
                bool isExists = false;

                foreach (var previousInvite in previousTripInvites)
                {
                    if (previousInvite.TripId == createTripInvitesDTO.TripId &&
                        previousInvite.OfferId == offerId)
                    {
                        isExists = true;
                        break;
                    }
                }

                if (isExists)
                {
                    continue;
                }

                var offer = await _offerRepository.GetByIdAsync(offerId);

                ExceptionMethods.OfferNullCheck(offer);

                newInvites.Add(new Invite
                {
                    IsAccepted = false,
                    IsAnswered = false,
                    OfferId = offerId,
                    UserId = offer.OfferCreatorId,
                    TripId = createTripInvitesDTO.TripId
                });
            }

            if (newInvites.Count > 0)
            {
                await _inviteRepository.AddRangeAsync(newInvites);
            }
        }
    }
}
