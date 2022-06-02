using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Core.Helpers;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class Repository<TEntity> 
        : RepositoryBase<TEntity>, IRepository<TEntity> where TEntity : class
    {
        private ApplicationContext _context;

        public Repository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<PaginatedIQueryable<TEntity>> GetPaginatedListAsync(
            ISpecification<TEntity> specification, 
            int pageNumber, 
            int pageSize)
        {
            var evaluator = new SpecificationEvaluator();

            return await PaginateAsync(
                evaluator.GetQuery(_context.Set<TEntity>(), specification), 
                pageNumber, 
                pageSize);
        }

        private async Task<PaginatedIQueryable<TEntity>> PaginateAsync(
            IQueryable<TEntity> source, int pageNumber, int pageSize)
        {
            var count = await source.CountAsync();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            
            return new PaginatedIQueryable<TEntity>(items, count);
        }
    }
}
