using System;
using ShopApp.Business.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Concrete
{
    public class OrderService : IOrderService
    {
        public Task<ResponseDto<NoContent>> CancelOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(int id, OrderState orderState)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> CreateAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<Order>> GetOrderAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<Order>>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<Order>>> GetOrdersAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<Order>>> GetOrdersAsync(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
