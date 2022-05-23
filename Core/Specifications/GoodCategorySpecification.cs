using Ardalis.Specification;
using Core.Entities.GoodCategoryEntity;

namespace Core.Specifications
{
    public static class GoodCategorySpecification
    {
        internal class GetByName : Specification<GoodCategory>, ISingleResultSpecification<GoodCategory>
        {
            public GetByName(string goodCategoryName)
            {
                Query.Where(g => g.Name == goodCategoryName.ToUpper());
            }
        }
    }
}
