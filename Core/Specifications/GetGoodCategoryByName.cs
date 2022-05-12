using Core.Entities.GoodCategoryEntity;

namespace Core.Specifications
{
    public class GetGoodCategoryByName: BaseSpecification<GoodCategory>
    {
        public GetGoodCategoryByName(string goodCategoryName) : base(g => g.Name == goodCategoryName.ToUpper())
        {

        }
    }
}
