using Ardalis.Specification;
using Core.DTO;
using Core.Entities.OfferEntity;

namespace Core.Specifications
{
    public static class OfferSpecification
    {
        internal class GetById: Specification<Offer>, ISingleResultSpecification<Offer>
        {
            public GetById(int offerId, string userId)
            {
                Query.Where(o => o.Id == offerId && o.OfferCreatorId == userId)
                     .Include(offer => offer.Point)
                     .Include(offer => offer.OfferRole)
                     .Include(offer => offer.GoodCategory);
            }
        }

        internal class GetByUserId: Specification<Offer>
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

        internal class GetByTripId : Specification<Offer>
        {
            public GetByTripId(int tripId)
            {
                Query.Where(o => o.RelatedTripId == tripId)
                    .Include(offer => offer.Point)
                    .Include(offer => offer.OfferRole)
                    .Include(offer => offer.GoodCategory);
            }
        }
    }
}
