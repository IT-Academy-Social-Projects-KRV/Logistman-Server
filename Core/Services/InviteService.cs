using Core.Entities.InviteEntity;
using Core.Entities.OfferEntity;
using Core.Entities.TripEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Specifications;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Services
{
    public class InviteService : IInviteService
    {
        private readonly IRepository<Invite> _inviteRepository;

        public InviteService(
            IRepository<Invite> inviteRepository)
        {
            _inviteRepository = inviteRepository;
        }


        public async Task ManageTripInvitesAsync(Trip trip, List<Offer> offers)
        {
            var previousTripInvites = await _inviteRepository.ListAsync(
                new InviteSpecification.GetByTripId(trip.Id));
            var newInvites = new List<Invite>();
            var invitesIdsForDelete = new List<int>();

            if (previousTripInvites.Count == 0)
            {
                newInvites.Add(new Invite
                {
                    IsAccepted = false,
                    IsAnswered = false,
                    OfferId = null,
                    TripId = trip.Id,
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

                if (offers.Any(o => o.Id == offerId))
                {
                    offers.Remove(offers.First(o => o.Id == offerId));
                }
                else
                {
                    invitesIdsForDelete.Add(previousInvite.Id);
                }
            }

            foreach (var offer in offers)
            {
                newInvites.Add(new Invite
                {
                    IsAccepted = false,
                    IsAnswered = false,
                    Offer = offer,
                    UserId = offer.OfferCreatorId,
                    TripId = trip.Id
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
    }
}
