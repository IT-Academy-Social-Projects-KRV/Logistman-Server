using Ardalis.Specification;
using Core.Entities.NotificationEntity;
using System.Collections.Generic;

namespace Core.Specifications
{
    public static class NotificationSpecification
    {
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
    }
}
