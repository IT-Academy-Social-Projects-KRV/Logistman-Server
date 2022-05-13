using AutoMapper;
using Core.DTO.PointDTO;
using Core.Entities.PointEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class PointProfiles : Profile
    {
        public PointProfiles()
        {
            CreateMap<Point, PointInfoDTO>().ReverseMap();
            CreateMap<PointInfoDTO, Point>().ReverseMap();
        }
    }
}
