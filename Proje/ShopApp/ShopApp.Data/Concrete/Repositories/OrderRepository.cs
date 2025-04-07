using System;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data.Concrete.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
