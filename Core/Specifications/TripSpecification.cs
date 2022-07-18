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
                    .Include(t => t.Car)
                    .Include(t => t.User)
                    .Include(t => t.Points)
                    .ThenInclude(t => t.Offer)
                    .ThenInclude(t => t.OfferRole)
                    .Include(t => t.Points)
                    .ThenInclude(t => t.Offer)
                    .ThenInclude(t => t.GoodCategory);
            }

            public GetById(int tripId, string userId)
            {
                Query
                    .Where(t => t.Id == tripId && 
                                t.TripCreatorId == userId)
                    .Include(t => t.Offers)
                    .Include(t => t.Car)
                    .Include(t => t.User)
                    .Include(t => t.Points)
                    .ThenInclude(t => t.Offer)
                    .ThenInclude(t => t.OfferRole)
                    .Include(t => t.Points)
                    .ThenInclude(t => t.Offer)
                    .ThenInclude(t => t.GoodCategory);
            }
        }

        internal class GetValidTripById : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetValidTripById(int tripId, float totalWeight)
            {
                Query
                    .Where(t => tripId == t.Id
                                && !t.IsActive
                                && !t.IsEnded
                                && t.LoadCapacity >= totalWeight
                                && DateTimeOffset.UtcNow <= t.DepartureDate)
                    .Include(t => t.Offers)
                    .Include(t => t.Points);
            }
        }

        internal class GetInTheSameDayByCreatorId : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetInTheSameDayByCreatorId(
                DateTimeOffset tripDepartureDate,
                string creatorId)
            {
                Query.Where(t => t.TripCreatorId == creatorId
                                 && !t.IsEnded
                                 && (t.DepartureDate.Date == tripDepartureDate.Date));
            }
        }

        internal class GetRoutes : Specification<Trip>
        {
            public GetRoutes(PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(t => !t.IsActive && !t.IsEnded && t.DepartureDate > DateTimeOffset.UtcNow)
                    .Include(t => t.User)
                    .Include(t => t.Points)
                    .Include(t => t.Car)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }

        internal class GetRoutesByUserId : Specification<Trip>
        {
            public GetRoutesByUserId(string userId)
            {
                Query
                    .Where(t => t.TripCreatorId == userId && !t.IsActive && !t.IsEnded)
                    .Include(t => t.Points)
                    .Include(t => t.Car)
                    .Include(t => t.Offers);
            }
        }

        internal class GetRouteById : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetRouteById(int tripId)
            {
                Query.Where(t => t.Id == tripId && !t.IsActive && !t.IsEnded);
            }
        }

        internal class GetActiveByUserId : Specification<Trip>
        {
            public GetActiveByUserId(string userId)
            {
                Query.Where(t => t.TripCreatorId == userId && t.IsActive);
            }
        }

        internal class GetActiveByUserIdWithOffers : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetActiveByUserIdWithOffers(string userId)
            {
                Query
                    .Where(t => t.TripCreatorId == userId && t.IsActive)
                    .Include(t => t.Offers);
            }
        }

        internal class GetActiveOrWithRelatedOffersByCarId : Specification<Trip>, 
            ISingleResultSpecification<Trip>
        {
            public GetActiveOrWithRelatedOffersByCarId(int carId)
            {
                Query
                    .Where(t =>
                        t.TransportationCarId == carId
                        && (t.IsActive || (!t.IsActive && !t.IsEnded && t.Offers.Count != 0)));
            }
        }

        internal class GetRoutesWithoutRelatedOffersByCarId : Specification<Trip>
        {
            public GetRoutesWithoutRelatedOffersByCarId(int carId)
            {
                Query
                    .Where(t =>
                        t.TransportationCarId == carId
                        && (!t.IsActive && !t.IsEnded && t.Offers.Count == 0))
                    .Include(t => t.Points);
            }
        }

        internal class GetActiveById : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetActiveById(int tripId)
            {
                Query.Where(t => t.Id == tripId && t.IsActive);
            }
        }

        internal class GetRoutesByCreatorId : Specification<Trip>
        {
            public GetRoutesByCreatorId(PaginationFilterDTO paginationFilter, string tripCreatorId)
            {
                Query
                    .Where(t => t.TripCreatorId == tripCreatorId && !t.IsActive && !t.IsEnded)
                    .Include(t => t.Points)
                    .Include(t => t.Car)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }

        internal class GetExpiredRoutes : Specification<Trip>
        {
            public GetExpiredRoutes()
            {
                Query
                    .Where(t => !t.IsActive
                        && !t.IsEnded
                        && t.Offers.Count == 0
                        && t.DepartureDate <= DateTimeOffset.UtcNow)
                    .Include(t => t.Points);
            }
        }

        internal class GetRouteByUserIdAndId : Specification<Trip>, ISingleResultSpecification<Trip>
        {
            public GetRouteByUserIdAndId(string userId, int tripId)
            {
                Query.Where(t => t.Id == tripId && !t.IsActive && !t.IsEnded &&
                                 t.TripCreatorId == userId);
            }
        }
    }
}
