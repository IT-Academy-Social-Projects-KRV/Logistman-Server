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
            CreateMap<PointData, PointOfferCreateTripDTO>()
                .ForMember(dest => dest.CreatorRoleName, opt => opt.MapFrom(point => point.Offer.OfferRole.Name))
                .ForMember(dest => dest.Settlement, opt => opt.MapFrom(point => point.Settlement))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(point => point.Location.Y))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(point => point.Location.X))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(point => point.Offer.StartDate.ToString("yyyy/MM/dd HH:mm")))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(point => point.Address))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(point => point.Region))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(point => point.Country))
                .ForMember(dest => dest.Postcode, opt => opt.MapFrom(point => point.Postcode))
                .ForMember(dest => dest.PointId, opt => opt.MapFrom(point => point.Id))
                .ForMember(dest => dest.OfferId, opt => opt.MapFrom(point => point.OfferId))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(point => point.Offer.Description))
                .ForMember(dest => dest.RelatedTripId, opt => opt.MapFrom(point => point.Offer.RelatedTripId))
                .ForMember(dest => dest.GoodsWeight, opt => opt.MapFrom(point => point.Offer.GoodsWeight))
                .ForMember(dest => dest.GoodCategoryName, opt => opt.MapFrom(point => point.Offer.GoodCategory.Name))
                .ForMember(dest => dest.CreatorRoleName, opt => opt.MapFrom(point => point.Offer.OfferRole.Name));
        }
    }
}
