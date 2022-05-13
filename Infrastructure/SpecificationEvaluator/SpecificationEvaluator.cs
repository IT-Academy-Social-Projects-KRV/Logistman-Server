using System.Linq;
<<<<<<< HEAD
using System.Threading.Tasks;
=======
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.SpecificationEvaluator
{
    public class SpecificationEvaluator<TEntity> where TEntity : class
    {
<<<<<<< HEAD
        public static async Task<IQueryable<TEntity>> GetQueryAsync(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
=======
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpecification<TEntity> specification)
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace
        {
            var query = inputQuery;

            if (specification.Criteria != null)
            {
<<<<<<< HEAD
                query = await Task.Run(() => query.Where(specification.Criteria));
=======
                query = query.Where(specification.Criteria);
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace
            }

            if (specification.OrderBy != null)
            {
<<<<<<< HEAD
                query = await Task.Run(() => query.OrderByDescending(specification.OrderBy));
=======
                query = query.OrderBy(specification.OrderBy);
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace
            }

            if (specification.OrderByDescending != null)
            {
<<<<<<< HEAD
                query = await Task.Run(() => query.OrderByDescending(specification.OrderByDescending));
            }

            query = await Task.Run(() => specification.Includes.Aggregate(query, (current, include) => current.Include(include)));
=======
                query = query.OrderByDescending(specification.OrderByDescending);
            }

            query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace

            return query;
        }
    }
}
