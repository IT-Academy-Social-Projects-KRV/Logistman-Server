using System.Linq;

namespace Core.Helpers
{
    public class PaginatedIQueryable<TEntity>
    {
        public int Count { get; private set; }

        public IQueryable<TEntity> PaginatedItems { get; set; }

        public PaginatedIQueryable(IQueryable<TEntity> paginatedItems, int count)
        {
            PaginatedItems = paginatedItems;
            Count = count;
        }
    }
}
