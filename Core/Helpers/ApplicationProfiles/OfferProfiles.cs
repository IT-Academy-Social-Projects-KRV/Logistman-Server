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
                .ForMember(dest => dest.Role, opt => opt.MapFrom(role => role.Role.Name))
                .ForMember(dest => dest.GoodCategory, opt => opt.MapFrom(category => category.GoodCategory.Name));
        }
    }
}
