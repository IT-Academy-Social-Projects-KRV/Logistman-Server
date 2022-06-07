using Ardalis.Specification.EntityFrameworkCore;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class Repository<TEntity> 
        : RepositoryBase<TEntity>, IRepository<TEntity> where TEntity : class
    {
        public Repository(ApplicationContext context) : base(context)
        {

        }
    }
}
