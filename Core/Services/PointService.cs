using AutoMapper;
using Core.DTO;
using Core.Entities.PointEntity;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using Core.Specifications;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PointService : IPointService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<PointData> _pointRepository;
        private readonly IRepository<Trip> _tripRepository;

        public PointService(
            IMapper mapper,
            IRepository<PointData> pointRepository,
            IRepository<Trip> tripRepository)
        {
            _mapper = mapper;
            _pointRepository = pointRepository;
            _tripRepository = tripRepository;
        }

        public async Task<PointData> CreateAsync(PointDTO pointDTO)
        {
            var point = _mapper.Map<PointData>(pointDTO);

            await _pointRepository.AddAsync(point);

            return point;
        }

        public List<PointDTO> SortByOrder(List<PointDTO> pointsDTOs)
        {
            var sortedPointsByOrder = pointsDTOs.OrderBy(p => p.Order).ToList();

            for (int i = 0; i < sortedPointsByOrder.Count(); i++)
            {
                if (sortedPointsByOrder[i].Order != i + 1)
                {
                    throw new HttpException(ErrorMessages.InvalidOrder, HttpStatusCode.BadRequest);
                }
            }

            return sortedPointsByOrder;
        }

        public List<PointTripDTO> SortByOrder(List<PointTripDTO> pointsDTOs)
        {
            var sortedPointsByOrder = pointsDTOs.OrderBy(p => p.Order).ToList();

            for (int i = 0; i < sortedPointsByOrder.Count(); i++)
            {
                if (sortedPointsByOrder[i].Order != i + 1)
                {
                    throw new HttpException(ErrorMessages.InvalidOrder, HttpStatusCode.BadRequest);
                }
            }

            return sortedPointsByOrder;
        }

        public async Task SetTripIdToListAsync(List<PointDTO> pointsDTOs, int tripId)
        {
            var trip = await _tripRepository.GetByIdAsync(tripId);

            ExceptionMethods.TripNullCheck(trip);

            foreach (var pointDTO in pointsDTOs)
            {
                pointDTO.TripId = tripId;
            }
        }

        public async Task ResetTripPointOrdersAsync(int tripId)
        {
            var points = await _pointRepository.ListAsync(
                new PointDataSpecification.GetByTripId(tripId));

            int order = 1;

            foreach (var point in points)
            {
                if (point.OfferId != null)
                {
                    point.TripId = null;
                    point.Order = 0;
                }
                else
                {
                    point.Order = order;
                    order++;
                }
            }

            await _pointRepository.SaveChangesAsync();
        }
    }
}
