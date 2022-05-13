using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SpecificationEvaluator
{
    public class SpecificationEvaluator<TEntity> where TEntity : class
    {
        public static async Task<IQueryable<TEntity>> GetQueryAsync(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
        {
            var query = inputQuery;

            if (specification.Criteria != null)
            {
                query = await Task.Run(() => query.Where(specification.Criteria));
            }

            if (specification.OrderBy != null)
            {
                query = await Task.Run(() => query.OrderByDescending(specification.OrderBy));
            }

            if (specification.OrderByDescending != null)
            {
                query = await Task.Run(() => query.OrderByDescending(specification.OrderByDescending));
            }

            query = await Task.Run(() => specification.Includes.Aggregate(query, (current, include) => current.Include(include)));

            return query;
        }
    }
}
