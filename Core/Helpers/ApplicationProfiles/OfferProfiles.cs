using AutoMapper;
using Core.DTO.NotificationDTO;
using Core.DTO.OfferDTO;
using Core.Entities.OfferEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class OfferProfiles : Profile
    {
        public OfferProfiles()
        {
            CreateMap<Offer, OfferCreateDTO>().ReverseMap()
                .ForMember(offer => offer.Point, dto => dto.Ignore())
                .ForMember(offer => offer.OfferRole, dto => dto.Ignore())
                .ForMember(offer => offer.GoodCategory, dto => dto.Ignore());
            CreateMap<OfferInfoDTO, Offer>().ReverseMap()
                .ForMember(dest => dest.CreatorRoleName, opt => opt.MapFrom(role => role.OfferRole.Name))
                .ForMember(dest => dest.GoodCategoryName, opt => opt.MapFrom(category => category.GoodCategory.Name));
            CreateMap<Offer, OfferPreviewDTO>()
                .ForMember(dest => dest.CreatorRoleName, opt => opt.MapFrom(offer => offer.OfferRole.Name))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(offer => offer.Point.Address))
                .ForMember(dest => dest.Settlement, opt => opt.MapFrom(offer => offer.Point.Settlement))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(offer => offer.Point.Region))
                .ForMember(dest => dest.GoodCategoryName, opt => opt.MapFrom(offer => offer.GoodCategory.Name));
            CreateMap<Offer, BriefNotificationDTO>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(offer => offer.User.Id))
                .ForMember(dest => dest.OfferId, opt => opt.MapFrom(offer => offer.Id));
            CreateMap<Offer, OfferPreviewForNotificationDTO>()
                .ForMember(dest => dest.CreatorRoleName, opt => opt.MapFrom(offer => offer.OfferRole.Name))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(offer => offer.Point.Address))
                .ForMember(dest => dest.Settlement, opt => opt.MapFrom(offer => offer.Point.Settlement))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(offer => offer.Point.Region))
                .ForMember(dest => dest.GoodCategoryName, opt => opt.MapFrom(offer => offer.GoodCategory.Name));
            CreateMap<Offer, OfferPreviewInTripInviteDTO>()
                .ForMember(dest => dest.CreatorRoleName, opt => opt.MapFrom(offer => offer.OfferRole.Name))
                .ForMember(dest => dest.PointInfo, opt => opt.MapFrom(offer => offer.Point))
                .ForMember(dest => dest.GoodCategoryName, opt => opt.MapFrom(offer => offer.GoodCategory.Name));
            CreateMap<Offer, OfferCreateTripDTO>()
                .ForMember(dest => dest.CreatorRoleName, opt => opt.MapFrom(offer => offer.OfferRole.Name))
                .ForMember(dest => dest.Settlement, opt => opt.MapFrom(offer => offer.Point.Settlement))
                .ForMember(dest => dest.Latitude, opt => opt.MapFrom(offer => offer.Point.Location.Y))
                .ForMember(dest => dest.Longitude, opt => opt.MapFrom(offer => offer.Point.Location.X))
                .ForMember(dest => dest.CreationDate, opt => opt.MapFrom(offer => offer.CreationDate.ToString("yyyy/MM/dd HH:mm")))
                .ForMember(dest => dest.Key, opt => opt.MapFrom(offer => offer.Id));
        }
    }
}
