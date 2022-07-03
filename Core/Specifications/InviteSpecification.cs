using Ardalis.Specification;
using Core.DTO;
using Core.Entities.InviteEntity;
using System.Collections.Generic;

namespace Core.Specifications
{
    public static class InviteSpecification
    {
        internal class GetByTripId : Specification<Invite>
        {
            public GetByTripId(int tripId)
            {
                Query.Where(i => i.TripId == tripId);
            }
        }

        internal class GetByIds : Specification<Invite>
        {
            public GetByIds(List<int> invitesIds)
            {
                Query.Where(i => invitesIds.Contains(i.Id));
            }
        }

        internal class GetUnansweredByInviteAndUserIds : Specification<Invite>,
                                                         ISingleResultSpecification<Invite>
        {
            public GetUnansweredByInviteAndUserIds(int inviteId, string userId)
            {
                Query.Where(i => i.Id == inviteId && i.UserId == userId && !i.IsAnswered);
            }
        }

        internal class GetOffersInvites : Specification<Invite>
        {
            public GetOffersInvites(string userId, PaginationFilterDTO paginationFilter)
            {
                Query.Where(i => i.UserId == userId && i.OfferId != null)
                     .Include(i => i.Trip)
                     .ThenInclude(t => t.User)
                     .Include(i => i.Offer)
                     .ThenInclude(o => o.GoodCategory)
                     .Include(i => i.Offer)
                     .ThenInclude(o => o.OfferRole)
                     .Include(i => i.Offer)
                     .ThenInclude(o => o.Point)
                     .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                     .Take(paginationFilter.PageSize)
                     .AsNoTracking();
            }
        }

        internal class GetDriverInvites : Specification<Invite>
        {
            public GetDriverInvites(string userId)
            {
                Query
                    .Where(i => i.UserId == userId && i.OfferId == null)
                    .Include(i => i.Trip)
                    .AsNoTracking();
            }
        }
    }
}
