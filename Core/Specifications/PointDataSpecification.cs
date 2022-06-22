using System.Collections.Generic;
using System.Linq;
using Ardalis.Specification;
using Core.DTO.TripDTO;
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
        internal class GetByIds : Specification<PointData>
        {
            public GetByIds(List<int> pointIds)
            {
                Query.Where(p => pointIds.Contains(p.Id));
            }
        }
    }
}
