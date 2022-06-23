using Core.Entities.OfferEntity;
using Core.Entities.TripEntity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces.CustomService
{
    public interface IInviteService
    {
        Task ManageTripInvitesAsync(Trip trip, List<Offer> offers);
    }
}
