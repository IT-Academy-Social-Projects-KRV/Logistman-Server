using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    // TEST CHANGES
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync<TKey>(TKey id);
        Task InsertAsync(TEntity entity);
        void DeleteAsync(TEntity entityToDelete);
        void UpdateAsync(TEntity entityToUpdate);
    }
}
