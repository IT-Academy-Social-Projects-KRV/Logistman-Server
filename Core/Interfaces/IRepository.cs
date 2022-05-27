using Ardalis.Specification;
using System.Linq;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetIQuaryableBySpec(ISpecification<TEntity> specification);
    }
}
