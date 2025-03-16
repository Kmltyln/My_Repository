 using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace ShopApp.Data.Abstract;

public interface IGenericRepository<TEntity>where TEntity:class
{
Task<TEntity> CreateAsync(TEntity entity);
Task UpdateAsync(TEntity entity);
Task DeleteAsync(TEntity entity);

Task <TEntity>GetByIdASync(
        Expression<Func<TEntity,bool>>?options,
        Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>predicate);
Task <List<TEntity>>GetAllAsync(Expression<Func<TEntity,bool>>?options,
        Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>predicate);
Task <int>GetCountAsync(Expression<Func<TEntity,bool>>? options,
        Func<IQueryable<TEntity>,IIncludableQueryable<TEntity,object>>predicate);
}
