using AutoMapper;
using Core.DTO;
using Core.Entities.GoodCategoryEntity;

namespace Core.Helpers.ApplicationProfiles
{
    public class GoodCategoryProfiles: Profile
    {
        public GoodCategoryProfiles()
        {
            CreateMap<GoodCategory, GoodCategoryDTO>().ReverseMap();
        }
    }
}
