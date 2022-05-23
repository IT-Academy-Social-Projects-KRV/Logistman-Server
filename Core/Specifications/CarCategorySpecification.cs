
using Ardalis.Specification;
using Core.Entities.CarCategoryEntity;

namespace Core.Specifications
{
    public static class CarCategorySpecification
    {
        internal class GetByName: Specification<CarCategory>, ISingleResultSpecification<CarCategory>
        {
            public GetByName(string categoryName)
            {
                Query.Where(c => c.Name == categoryName);
            }
        }
    }
}
