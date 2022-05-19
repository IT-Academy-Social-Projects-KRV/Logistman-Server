using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Core.Interfaces;
using Infrastructure.Data;
using System.Linq;

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

        public IQueryable<TEntity> GetListBySpecAsync(ISpecification<TEntity> specification)
        {
            return ApplySpecification(specification);
        }

        private IQueryable<TEntity> ApplySpecification(ISpecification<TEntity> specification)
        {
            var evaluator = new SpecificationEvaluator();
            return evaluator.GetQuery(_context.Set<TEntity>(), specification);
        }
    }
}
