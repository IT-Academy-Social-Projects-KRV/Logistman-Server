using Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Helpers
{
    public class PaginatedList<TEntity>
    {
        public int PageNumber { get; private set; }
        public int TotalPages { get; private set; }
        public int TotalItems { get; private set; }

        public bool HasPreviousPage => PageNumber > 1;
        public bool HasNextPage => PageNumber < TotalPages;

        public List<TEntity> Items { get; set; }

        public PaginatedList(List<TEntity> items, int pageNumber, int totalPages, int totalItems)
        {
            PageNumber = pageNumber;
            TotalPages = totalPages;
            TotalItems = totalItems;
            Items = items;
        }

        public static int GetTotalPages(PaginationFilterDTO paginationFilter, int count)
        {
            var totalPages = (int)Math.Ceiling(count / (double)paginationFilter.PageSize);

            if (paginationFilter.PageNumber > totalPages)
            {
                paginationFilter.PageNumber = totalPages;
            }

            return totalPages;
        }

        public static PaginatedList<TEntity> Evaluate(
            List<TEntity> items, int pageNumber, int count, int totalPages)
        {
            if (count == 0)
            {
                return null;
            }

            return new PaginatedList<TEntity>(items, pageNumber, totalPages, count);
        }
    }
}
