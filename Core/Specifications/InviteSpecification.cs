using Ardalis.Specification;
using Core.Entities.InviteEntity;
using System.Collections.Generic;

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

        internal class GetByIds : Specification<Invite>
        {
            public GetByIds(List<int> invitesIds)
            {
                Query.Where(i => invitesIds.Contains(i.Id));
            }
        }
    }
}
