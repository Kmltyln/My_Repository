using System;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data.Concrete.Repositories
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        public CartRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
