using AutoMapper;
using Core.DTO.CarCategoryDTO;
using Core.Entities.CarCategoryEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class CarCategoryProfile: Profile
    {
        public CarCategoryProfile()
        {
            CreateMap<CarCategory, CarCategoryDTO>();
        }
    }
}
