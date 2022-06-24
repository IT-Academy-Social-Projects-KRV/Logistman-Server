using AutoMapper;
using Core.DTO.TripDTO;
using Core.Entities.TripEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class TripProfile : Profile
    {
        public TripProfile()
        {
            CreateMap<CreateTripDTO, Trip>();
            CreateMap<Trip, RouteDTO>();
            CreateMap<Trip, TripPreviewForInviteDTO>()
                .ForMember(dest => dest.CreatorFullName, dto => dto.MapFrom(trip => trip.User));
        }
    }
}
