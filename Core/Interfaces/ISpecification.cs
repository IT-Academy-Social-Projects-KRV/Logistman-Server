using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.Interfaces
{
    public interface ISpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> Criteria { get; }
        IList<Expression<Func<TEntity, object>>> Includes { get; }
        Expression<Func<TEntity, object>> OrderBy { get; }
        Expression<Func<TEntity, object>> OrderByDescending { get; }
    }
}
