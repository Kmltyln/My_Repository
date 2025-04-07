using System;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data.Concrete.Repositories
{
    public class CartItemRepository : GenericRepository<CartItem>, ICartItemRepository
    {
        public CartItemRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
