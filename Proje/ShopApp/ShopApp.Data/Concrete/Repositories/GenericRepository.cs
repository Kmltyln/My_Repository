using System;
using ShopApp.Data.Abstract;

namespace ShopApp.Data.Concrete.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    public Task<TEntity> CreateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<TEntity>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TEntity> GetByIdASync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<int> GetCountAsync()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(TEntity entity)
    {
        throw new NotImplementedException();
    }
}
