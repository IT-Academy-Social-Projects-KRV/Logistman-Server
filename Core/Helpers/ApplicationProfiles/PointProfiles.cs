using AutoMapper;
using Core.DTO;
using Core.Entities.PointEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class PointProfiles : Profile
    {
        public PointProfiles()
        {
            CreateMap<Point, PointDTO>().ReverseMap();
        }
    }
}
