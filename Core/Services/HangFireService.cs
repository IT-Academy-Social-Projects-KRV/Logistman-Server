using Core.Entities.PointEntity;
using Core.Entities.TripEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Services
{
    public class HangFireService : IHangFireService
    {
        private readonly IRepository<PointData> _pointDataRepository;
        private readonly IRepository<Trip> _tripRepository;

        public HangFireService(
            IRepository<PointData> pointDataRepository,
            IRepository<Trip> tripRepository)
        {
            _pointDataRepository = pointDataRepository;
            _tripRepository = tripRepository;
        }

        public async Task DeleteExpiredRoutesAsync()
        {
            var trips = await _tripRepository.ListAsync(new TripSpecification.GetExpiredRoutes());
            var points = new List<PointData>();

            foreach (var trip in trips)
            {
                points.AddRange(trip.Points);
            }

            await _pointDataRepository.DeleteRangeAsync(points);
            await _tripRepository.DeleteRangeAsync(trips);
        }

        public async Task ActivatePossibleTripsAsync()
        {
            var trips = await _tripRepository.ListAsync(
                new TripSpecification.GetReadyForActivationTrips());

            foreach (var trip in trips)
            {
                trip.IsActive = true;
            }

            await _tripRepository.SaveChangesAsync();
        }
    }
}
