using AutoMapper;
using Core.DTO;
using Core.Entities.PointEntity;
using Core.Entities.TripEntity;
using Core.Exceptions;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Core.Resources;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Core.Services
{
    public class PointService : IPointService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Point> _pointRepository;
        private readonly IRepository<Trip> _tripRepository;

        public PointService(
            IMapper mapper,
            IRepository<Point> pointRepository,
            IRepository<Trip> tripRepository)
        {
            _mapper = mapper;
            _pointRepository = pointRepository;
            _tripRepository = tripRepository;
        }

        public async Task<int> CreateAsync(PointDTO pointDTO)
        {
            var point = _mapper.Map<Point>(pointDTO);
            await _pointRepository.AddAsync(point);

            return point.Id;
        }

        public List<PointDTO> SortByOrder(List<PointDTO> pointsDTOs)
        {
            foreach (var pointDTO in pointsDTOs)
            {
                ExceptionMethods.PointDTONullCheck(pointDTO);
            }

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
                ExceptionMethods.PointDTONullCheck(pointDTO);
                pointDTO.TripId = tripId;
            }
        }
    }
}
