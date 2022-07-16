using Ardalis.Specification;
using Core.DTO;
using Core.Entities.OfferEntity;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Specifications
{
    public static class OfferSpecification
    {
        internal class GetById : Specification<Offer>, ISingleResultSpecification<Offer>
        {
            public GetById(int offerId, string userId)
            {
                Query
                    .Where(o => o.Id == offerId && o.OfferCreatorId == userId)
                    .Include(o => o.Point)
                    .Include(o => o.OfferRole)
                    .Include(o => o.GoodCategory);
            }

            public GetById(int offerId, int tripId, DateTimeOffset tripDepartureDate)
            {
                Query
                    .Where(o => o.Id == offerId
                                     && !o.IsClosed
                                     && (o.RelatedTripId == tripId || o.RelatedTripId == null)
                                     && o.StartDate <= tripDepartureDate)
                    .Include(o => o.Point);
            }
        }

        internal class GetByUserId : Specification<Offer>
        {
            public GetByUserId(string userId, PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(o => o.OfferCreatorId == userId)
                    .Include(o => o.Point)
                    .Include(o => o.OfferRole)
                    .Include(o => o.GoodCategory)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }

        internal class GetOffersNearRoute : Specification<Offer>
        {
            public GetOffersNearRoute(
                Geometry routeGeography,
                double dist,
                DateTimeOffset expirationDate,
                PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(offer => offer.Point.Location.IsWithinDistance(routeGeography, dist)
                    && !offer.IsClosed
                    && offer.RelatedTripId == null
                    && offer.StartDate <= expirationDate)
                    .Include(offer => offer.Point)
                    .Include(offer => offer.OfferRole)
                    .Include(offer => offer.GoodCategory)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }

        internal class GetOfferByIds : Specification<Offer>
        {
            public GetOfferByIds(List<int> offersIds)
            {
                Query
                    .Where(o => offersIds.Contains(o.Id))
                    .Include(o => o.User);
            }
        }

        internal class GetByTripId : Specification<Offer>
        {
            public GetByTripId(int tripId)
            {
                Query
                    .Where(o => o.RelatedTripId == tripId)
                    .Include(o => o.Point)
                    .Include(o => o.OfferRole)
                    .Include(o => o.GoodCategory)
                    .AsNoTracking();
            }
        }

        internal class GetOpenByUserId : Specification<Offer>
        {
            public GetOpenByUserId(string userId)
            {
                Query
                    .Where(o => o.OfferCreatorId == userId && !o.IsClosed)
                    .Include(o => o.Point);
            }
        }

        public class GetOpenByIdAndUserIdWithoutTrip : Specification<Offer>, ISingleResultSpecification<Offer>
        {
            public GetOpenByIdAndUserIdWithoutTrip(int offerId, string userId)
            {
                Query
                    .Where(o => o.Id == offerId
                    && o.OfferCreatorId == userId
                    && !o.IsClosed
                    && o.RelatedTripId == null)
                    .Include(o => o.Point);
            }
        }
    }
}
