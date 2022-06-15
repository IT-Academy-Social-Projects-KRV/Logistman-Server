using Ardalis.Specification;
using Core.Entities.PointEntity;

namespace Core.Specifications
{
    public static class PointDataSpecification
    {
        internal class GetByRouteId : Specification<PointData>
        {
            public GetByRouteId(int tripId)
            {
                Query
                    .Where(p => p.TripId == tripId)
                    .OrderBy(p => p.Order);
            }
        }
    }
}
