using Ardalis.Specification.EntityFrameworkCore;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class Repository<TEntity>
        : RepositoryBase<TEntity>, IRepository<TEntity> where TEntity : class
    {
        private ApplicationContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(ApplicationContext context) : base(context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }
    }
}
