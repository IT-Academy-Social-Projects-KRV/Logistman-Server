using Ardalis.Specification;
using Core.DTO;
using Core.Entities.NotificationEntity;
using System.Collections.Generic;

namespace Core.Specifications
{
    public static class NotificationSpecification
    {
        internal class GetSingleByTripId : Specification<Notification>,
                                           ISingleResultSpecification<Notification>
        {
            public GetSingleByTripId(int tripId)
            {
                Query.Where(n => n.TripId == tripId);
            }
        }

        internal class GetByTripId : Specification<Notification>
        {
            public GetByTripId(int tripId)
            {
                Query.Where(n => n.TripId == tripId);
            }
        }

        internal class GetByIds : Specification<Notification>
        {
            public GetByIds(List<int> notificationIds)
            {
                Query
                    .Where(n => notificationIds.Contains(n.Id));
            }
        }

        internal class GetByUserId : Specification<Notification>
        {
            public GetByUserId(string userId, PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(n => n.UserId == userId)
                    .Include(n => n.Trip)
                    .ThenInclude(t => t.User)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }
    }
}
