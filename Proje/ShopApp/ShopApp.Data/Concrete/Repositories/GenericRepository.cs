using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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

     public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? options = null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? predicate = null)
        {
            IQueryable<TEntity> query = _dbSet; //_dbContext.Products
            if(predicate != null){
                query = predicate(query);//_dbContext.Products.Include(x=>x.Category)
            }
            if(options!=null){
                query = query.Where(options);//_dbContext.Products.Include(x=>x.Category).Where(x=>x.IsHome==true)
            }
            return await query.ToListAsync();//_dbContext.Products.Include(x=>x.Category).Where(x=>x.IsHome==true).ToListAsync()
        }

    public Task<TEntity> GetByIdASync(Expression<Func<TEntity, bool>>? options=null, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? predicate=null )
    {
        throw new NotImplementedException();
    }

    public Task<int> GetCountAsync(Expression<Func<TEntity, bool>>? options, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> predicate)
    {
        throw new NotImplementedException();
    }

    public async  Task UpdateAsync(TEntity entity)
    {
        _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
    }
}
