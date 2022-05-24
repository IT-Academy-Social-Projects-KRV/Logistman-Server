using AutoMapper;
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
        }
    }
}
