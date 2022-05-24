﻿using Ardalis.Specification;
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
            public GetByUserId(string userId)
            {
                Query.Where(o => o.OfferCreatorId == userId)
                    .Include(offer => offer.Point)
                    .Include(offer => offer.OfferRole)
                    .Include(offer => offer.GoodCategory);
            }
        }
    }
}