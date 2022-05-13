using Ardalis.Specification.EntityFrameworkCore;
using Core.Interfaces;
using Infrastructure.Data;

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

        public async Task<IEnumerable<TEntity>> FindWithSpecificationAsync(ISpecification<TEntity> specification)
        {
            return await SpecificationEvaluator<TEntity>.GetQueryAsync(_context.Set<TEntity>().AsQueryable(), specification);
        }
    }
}
