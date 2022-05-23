using Ardalis.Specification;
using System.Linq;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetListBySpecAsync(ISpecification<TEntity> specification);
    }
}
