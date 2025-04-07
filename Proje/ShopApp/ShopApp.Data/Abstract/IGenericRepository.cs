 using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace ShopApp.Data.Abstract
{
    public interface IGenericRepository<TEntity>where TEntity:class
    {
    Task<TEntity> CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);

    Task <TEntity>GetASync(
            Expression<Func<TEntity,bool>>?options=null,
            Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>? predicate=null);
    Task <List<TEntity>>GetAllAsync(Expression<Func<TEntity,bool>>?options=null,
            Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>? predicate=null);
    Task <int>GetCountAsync(Expression<Func<TEntity,bool>>? options=null,
            Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>? predicate=null);
    }
}
