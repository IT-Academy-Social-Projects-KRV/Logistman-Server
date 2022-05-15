using Ardalis.Specification;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        
    }
}
