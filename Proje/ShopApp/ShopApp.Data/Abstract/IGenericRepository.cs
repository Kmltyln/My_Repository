 using System;

namespace ShopApp.Data.Abstract;

public interface IGenericRepository<TEntity>where TEntity:class
{
Task<TEntity> CreateAsync(TEntity entity);
Task UpdateAsync(TEntity entity);
Task DeleteAsync(TEntity entity);

Task <TEntity>GetByIdASync(int id);
Task <List<TEntity>>GetAllAsync();
Task <int>GetCountAsync();
}
