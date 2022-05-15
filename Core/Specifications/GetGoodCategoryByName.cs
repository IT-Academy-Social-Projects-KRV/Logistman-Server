using Ardalis.Specification;
using Core.Entities.GoodCategoryEntity;

namespace Core.Specifications
{
    public class GetGoodCategoryByName : Specification<GoodCategory>, ISingleResultSpecification<GoodCategory>
    {
        public GetGoodCategoryByName(string goodCategoryName)
        {
            Query.Where(g => g.Name == goodCategoryName.ToUpper());
        }
    }
}
