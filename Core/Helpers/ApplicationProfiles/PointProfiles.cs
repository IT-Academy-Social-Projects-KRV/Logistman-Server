using AutoMapper;
using Core.Constants;
using Core.DTO;
using Core.Entities.PointEntity;
using NetTopologySuite.Geometries;

namespace Core.Helpers.ApplicationProfiles
{
    public class PointProfiles : Profile
    {
        public PointProfiles()
        {
            CreateMap<PointDTO, PointData>()
                .ForMember(
                dest => dest.Location, 
                opt => opt.MapFrom(src => new Point(src.Longitude, src.Latitude) 
                { SRID = GeodeticSystem.WGS84 }
                ));
            CreateMap<PointData, PointDTO>()
                .ForMember(
                dest => dest.Longitude,
                opt => opt.MapFrom(src => src.Location.X))
                .ForMember(
                dest => dest.Latitude,
                opt => opt.MapFrom(src => src.Location.Y));
            CreateMap<PointData, PointPreviewDTO>();
        }
    }
}
