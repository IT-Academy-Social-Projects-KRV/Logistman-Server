using Ardalis.Specification;
using Core.DTO;
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
                Query
                    .Where(t => t.Id == tripId)
                    .Include(t => t.Offers)
                    .Include(t => t.Points);
            }
            public GetById(int tripId, float totalWeight)
            {
                Query
                    .Where(t => tripId == t.Id
                                && !t.IsActive
                                && !t.IsEnded
                                && t.LoadCapacity >= totalWeight
                                && DateTimeOffset.UtcNow <= t.ExpirationDate);
            }
        }

        internal class GetByTimeSpace : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetByTimeSpace(
                DateTimeOffset startDate,
                DateTimeOffset expirationDate,
                string creatorId)
            {
                Query.Where(t => t.TripCreatorId == creatorId
                                 && !t.IsEnded
                                 && ((t.StartDate >= startDate && t.StartDate < expirationDate) ||
                                     (t.ExpirationDate > startDate && t.ExpirationDate < expirationDate)));
            }
        }

        internal class GetRoutes : Specification<Trip>
        {
            public GetRoutes(PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(t => !t.IsActive && !t.IsEnded)
                    .Include(t => t.User)
                    .Include(t => t.Points)
                    .Include(t => t.Car)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }
    }
}
