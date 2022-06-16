using Ardalis.Specification;
using Core.DTO;
using Core.Entities.OfferEntity;
using NetTopologySuite.Geometries;
using System;

namespace Core.Specifications
{
    public static class OfferSpecification
    {
        internal class GetById : Specification<Offer>, ISingleResultSpecification<Offer>
        {
            public GetById(int offerId, string userId)
            {
                Query.Where(o => o.Id == offerId && o.OfferCreatorId == userId)
                     .Include(offer => offer.Point)
                     .Include(offer => offer.OfferRole)
                     .Include(offer => offer.GoodCategory);
            }
        }

        internal class GetByUserId : Specification<Offer>
        {
            public GetByUserId(string userId, PaginationFilterDTO paginationFilter)
            {
                Query
                    .Where(o => o.OfferCreatorId == userId)
                    .Include(offer => offer.Point)
                    .Include(offer => offer.OfferRole)
                    .Include(offer => offer.GoodCategory)
                    .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
                    .Take(paginationFilter.PageSize);
            }
        }

        internal class GetOffersNearRoute : Specification<Offer>
        {
            public GetOffersNearRoute(Geometry routeGeography, double dist, DateTimeOffset startDate, DateTimeOffset expirationDate)
            {
                Query
                    .Where(offer => offer.Point.Location.IsWithinDistance(routeGeography, dist)
                    && !offer.IsClosed
                    && offer.RelatedTripId == null
                    && startDate <= offer.ExpirationDate 
                    && offer.StartDate <= expirationDate)
                    .Include(offer => offer.Point)
                    .Include(offer => offer.OfferRole)
                    .Include(offer => offer.GoodCategory);
            }
        }
    }
}
