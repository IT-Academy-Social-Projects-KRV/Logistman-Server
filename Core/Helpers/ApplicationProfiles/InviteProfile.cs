using AutoMapper;
using Core.DTO.InviteDTO;
using Core.Entities.InviteEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class InviteProfile : Profile
    {
        public InviteProfile()
        {
            CreateMap<Invite, InvitePreviewDTO>()
                .ForMember(dest => dest.OfferInfo, opt => opt.MapFrom(invite => invite.Offer))
                .ForMember(dest => dest.TripInfo, opt => opt.MapFrom(invite => invite.Trip));
            CreateMap<Invite, DriverInvitePreviewDTO>();
        }
    }
}
