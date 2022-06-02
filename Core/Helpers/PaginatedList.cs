using System;
using System.Collections.Generic;

namespace Core.Helpers
{
    public class PaginatedList<TEntity>
    {
        public int PageNumber { get; private set; }

        public int TotalPages { get; private set; }

        public bool HasPreviousPage => PageNumber > 1;

        public bool HasNextPage => PageNumber < TotalPages;

        public List<TEntity> PaginatedItems { get; set; }

        public PaginatedList(List<TEntity> items, int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
            PaginatedItems = items;
        }
    }
}
