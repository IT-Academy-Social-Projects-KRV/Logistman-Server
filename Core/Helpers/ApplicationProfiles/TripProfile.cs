using System.Linq;
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
            CreateMap<Trip, RoutePreviewDTO>();
            CreateMap<Trip, TripPreviewForInviteDTO>()
                .ForMember(dest => dest.CreatorFullName, dto => dto.MapFrom(trip => trip.User));
            CreateMap<Trip, TripInfoDTO>()
                .ForMember(dest => dest.FullName, dto => dto.MapFrom(trip => trip.User))
                .ForMember(dest => dest.Model, dto => dto.MapFrom(trip => trip.Car.Model))
                .ForMember(dest => dest.RegistrationNumber, dto => dto.MapFrom(trip => trip.Car.RegistrationNumber))
                .ForMember(dest => dest.Points, dto => dto.MapFrom(trip => trip.Points));
        }
    }
}
