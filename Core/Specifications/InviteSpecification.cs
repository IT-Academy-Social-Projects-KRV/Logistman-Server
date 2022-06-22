using Ardalis.Specification;
using Core.Entities.InviteEntity;

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
    }
}
