using Ardalis.Specification;
using Core.Helpers;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        Task<PaginatedIQueryable<TEntity>> GetPaginatedListAsync(ISpecification<TEntity> specification, int pageNumber, int pageSize);
    }
}
