using Ardalis.Specification;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        Task AddRangeAsync(IEnumerable<TEntity> entities);
    }
}
