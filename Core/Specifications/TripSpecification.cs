using Ardalis.Specification;
using Core.Entities.TripEntity;
using System;

namespace Core.Specifications
{
    public static class TripSpecification
    {
        internal class GetById : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetById(int tripId)
            {
                Query.Where(t => t.Id == tripId);
            }
        }

        internal class GetByTimeSpace : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetByTimeSpace(DateTimeOffset startDate, DateTimeOffset expirationDate, string creatorId)
            {
                Query.Where(t => t.TripCreatorId == creatorId && !t.IsEnded &&
                                                       ((t.StartDate >= startDate && t.StartDate < expirationDate) ||
                                                       (t.ExpirationDate > startDate && t.ExpirationDate < expirationDate)));
            }
        }
    }
}
