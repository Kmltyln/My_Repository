using System;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data.Concrete.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
