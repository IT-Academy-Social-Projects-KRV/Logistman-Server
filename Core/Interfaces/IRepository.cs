using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Linq.Expressions;
using System;

namespace Core.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync<TKey>(TKey id);
        Task<TEntity> InsertAsync(TEntity entity);
        Task DeleteAsync(TEntity entityToDelete);
        Task UpdateAsync(TEntity entityToUpdate);
        Task<int> SaveChangesAsync();
        IQueryable<TEntity> Query(params Expression<Func<TEntity, object>>[] includes);
<<<<<<< HEAD
        Task<IEnumerable<TEntity>> FindWithSpecificationAsync(ISpecification<TEntity> specification);
=======
        IEnumerable<TEntity> FindWithSpecification(ISpecification<TEntity> specification);
>>>>>>> 8a83ac67acfb270be6b52f5d2140f970db84dace
    }
}
