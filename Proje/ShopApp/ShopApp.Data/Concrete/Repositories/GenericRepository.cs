using System;
using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Abstract;

namespace ShopApp.Data.Concrete.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext _dbContext;
    private readonly DbSet<TEntity> _dbSet;
    public GenericRepository(AppDbContext dbContext)
    {
            _dbContext=dbContext;
            _dbSet=dbContext.Set<TEntity>(); 
    }
    public async Task<TEntity> CreateAsync(TEntity entity)
    {
      await _dbSet.AddAsync(entity); 
      _dbSet.Add(entity);
      await _dbContext.SaveChangesAsync();
      return entity;
    }

    public async Task DeleteAsync(TEntity entity)
    {
       _dbSet.Remove(entity);
       await _dbContext.SaveChangesAsync(); 
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

    public async  Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}
