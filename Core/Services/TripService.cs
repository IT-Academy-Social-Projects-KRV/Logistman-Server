using Core.Entities.TripEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using System.Linq;

namespace Core.Services
{
    public class TripService : ITripService
    {
        private readonly IRepository<Trip> _tripRepository;

        public TripService(IRepository<Trip> tripRepository)
        {
            _tripRepository = tripRepository;
        }

        public bool CheckIsTripExistsById(int tripId)
        {
            return _tripRepository.Query()
                                  .SingleOrDefault(p => p.Id == tripId) != null;
        }
    }
}
