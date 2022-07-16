using Ardalis.Specification;
using Core.DTO;
using Core.Entities.InviteEntity;

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

        internal class GetUnansweredByInviteAndUserIds : Specification<Invite>,
                                                         ISingleResultSpecification<Invite>
        {
            public GetUnansweredByInviteAndUserIds(int inviteId, string userId)
            {
                Query.Where(i => i.Id == inviteId && i.UserId == userId && !i.IsAnswered);
            }
        }

        internal class GetByUserId : Specification<Invite>
        {
            public GetByUserId(string userId, PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(i => i.UserId == userId)
                    .Include(i => i.Trip)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize)
                    .AsNoTracking();
            }
        }
    }
}
