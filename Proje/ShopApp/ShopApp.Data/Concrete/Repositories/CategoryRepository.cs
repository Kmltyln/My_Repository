using System;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;
namespace ShopApp.Data.Concrete.Repositories
{
    public class CategoryRepository : GenericRepository<Category>,ICategoryRepository
    {
        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
