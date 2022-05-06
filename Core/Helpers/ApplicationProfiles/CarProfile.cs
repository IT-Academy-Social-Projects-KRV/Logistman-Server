using System;
using System.Linq;
using AutoMapper;
using Core.DTO.CarDTO;
using Core.Entities.CarEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class CarProfile : Profile
    {
        public CarProfile()
        {
            CreateMap<Car, CreateCarDTO>().ReverseMap()
                .ForMember(dest => dest.RegistrationNumber,
                    opt => opt.MapFrom(dto => 
                        string.Concat(dto.RegistrationNumber.Where(c => !char.IsWhiteSpace(c))).ToUpper()))
                .ForMember(dest => dest.Vin,
                    opt => opt.MapFrom(dto => dto.Vin.ToUpper()))
                .ForMember(dest => dest.TechnicalPassport,
                    opt => opt.MapFrom(dto => dto.TechnicalPassport.ToUpper()));
            CreateMap<CarDTO, Car>().ReverseMap()
                .ForMember(dest => dest.Category,
                    opt => opt.MapFrom(car => car.Category.Name));
        }
    }
}
