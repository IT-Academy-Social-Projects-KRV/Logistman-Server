using AutoMapper;
using Core.DTO.NotificationDTO;
using Core.Entities.NotificationEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, NotificationPreviewDTO>()
                .ForMember(dest => dest.OfferInfo, dto => dto.MapFrom(n => n.Offer))
                .ForMember(dest => dest.TripInfo, dto => dto.MapFrom(n => n.Trip));
        }
    }
}
