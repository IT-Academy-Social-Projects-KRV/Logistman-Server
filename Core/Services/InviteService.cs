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
using AutoMapper;
using Core.DTO.OfferDTO;
using Core.DTO.TripDTO;

namespace Core.Services
{
    public class InviteService : IInviteService
    {
        private readonly IRepository<Invite> _inviteRepository;
        private readonly IRepository<Trip> _tripRepository;
        private readonly IRepository<Offer> _offerRepository;
        private readonly IMapper _mapper;

        public InviteService(
            IRepository<Invite> inviteRepository,
            IRepository<Trip> tripRepository,
            IRepository<Offer> offerRepository,
            IMapper mapper)
        {
            _inviteRepository = inviteRepository;
            _tripRepository = tripRepository;
            _offerRepository = offerRepository;
            _mapper = mapper;
        }

        public async Task ManageAsync(ManageInviteDTO manageInviteDTO, string userId)
        {
            var invite = await _inviteRepository.GetBySpecAsync(
                new InviteSpecification.GetUnansweredByInviteAndUserIds(manageInviteDTO.InviteId, userId));

            ExceptionMethods.InviteNullCheck(invite);

            invite.IsAccepted = manageInviteDTO.IsAccepted;
            invite.IsAnswered = true;

            await _inviteRepository.SaveChangesAsync();
        }

        public async Task ManageTripInvitesAsync(CreateTripInvitesDTO createTripInvitesDTO)
        {
            var trip = await _tripRepository
                .GetBySpecAsync(new TripSpecification.GetUnactiveById(createTripInvitesDTO.TripId));

            ExceptionMethods.TripNullCheck(trip);

            var previousTripInvites = await _inviteRepository.ListAsync(
                new InviteSpecification.GetByTripId(createTripInvitesDTO.TripId));
            var newInvites = new List<Invite>();
            var invitesIdsForDelete = new List<int>();

            createTripInvitesDTO.OffersId = createTripInvitesDTO.OffersId.Distinct().ToList();

            if (previousTripInvites.Count == 0)
            {
                newInvites.Add(new Invite
                {
                    IsAccepted = false,
                    IsAnswered = false,
                    OfferId = null,
                    TripId = createTripInvitesDTO.TripId,
                    UserId = trip.TripCreatorId
                });
            }

            foreach (var previousInvite in previousTripInvites)
            {
                if (previousInvite.OfferId == null)
                {
                    continue;
                }

                var offerId = (int)previousInvite.OfferId;

                if (createTripInvitesDTO.OffersId.Contains(offerId))
                {
                    createTripInvitesDTO.OffersId.Remove(offerId);
                }
                else
                {
                    invitesIdsForDelete.Add(previousInvite.Id);
                }
            }

            foreach (var offerId in createTripInvitesDTO.OffersId)
            {
                var offer = await _offerRepository
                    .GetBySpecAsync(new OfferSpecification.GetOpenById(
                        offerId,
                        createTripInvitesDTO.TripId));

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

            if (invitesIdsForDelete.Count > 0)
            {
                var invitesForDelete = await _inviteRepository.ListAsync(
                    new InviteSpecification.GetByIds(invitesIdsForDelete));

                await _inviteRepository.DeleteRangeAsync(invitesForDelete);
            }

            if (newInvites.Count > 0)
            {
                await _inviteRepository.AddRangeAsync(newInvites);
            }
        }

        public async Task<List<InvitePreviewDTO>> OffersInvitesAsync(string userId)
        {
            var invites = await _inviteRepository.ListAsync(
                new InviteSpecification.GetOffersInvites(userId));

            var invitesDTOs = new List<InvitePreviewDTO>();

            foreach (var invite in invites)
            {
                invitesDTOs.Add(new InvitePreviewDTO
                {
                    Id = invite.Id,
                    OfferInfo = _mapper.Map<OfferPreviewForInviteDTO>(invite.Offer),
                    TripInfo = _mapper.Map<TripPreviewForInviteDTO>(invite.Trip)
                });
            }

            return invitesDTOs;
        }
    }
}
