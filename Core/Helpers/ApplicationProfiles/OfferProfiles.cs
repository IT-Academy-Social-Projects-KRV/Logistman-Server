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
                .ForMember(offer => offer.Role, dto => dto.Ignore());
        }
    }
}
