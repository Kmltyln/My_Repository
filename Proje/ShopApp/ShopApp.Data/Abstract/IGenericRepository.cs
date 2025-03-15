 using System;

namespace ShopApp.Data.Abstract;

public interface IGenericRepository<TEntity>where TEntity:class
{
Task<TEntity> CreateAsync(TEntity entity);
Task UpdateAsync(TEntity entity);
Task DeleteAsync(TEntity entity);

Task <TEntity>GetByIdASync(Expression<Func<TEntity,bool>>options);
Task <List<TEntity>>GetAllAsync();
Task <int>GetCountAsync();
}
