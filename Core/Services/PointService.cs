using System.Threading.Tasks;
using AutoMapper;
using Core.DTO.PointDTO;
using Core.Entities.PointEntity;
using Core.Interfaces;
using Core.Interfaces.CustomService;
using Microsoft.AspNetCore.Mvc;

namespace Core.Services
{
    public class PointService : IPointService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Point> _pointRepository;

        public PointService(IMapper mapper, IRepository<Point> pointRepository)
        {
            _mapper = mapper;
            _pointRepository = pointRepository;
        }
        public async Task<PointCreateDTO> CreatePoint(PointCreateDTO offerCreate)
        {
            await _pointRepository.InsertAsync(_mapper.Map<Point>(offerCreate));
            await _pointRepository.SaveChangesAsync();
            return _mapper.Map<PointCreateDTO>(offerCreate);
        }
    }
}
