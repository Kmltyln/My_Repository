using System;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Abstract
{
    public interface IOrderService
    {
        Task<ResponseDto<NoContent>>CreateAsync(Order order);
        Task<ResponseDto<List<Order>>>GetOrdersAsync();
         Task<ResponseDto<List<Order>>>GetOrdersAsync(string userId);
         Task<ResponseDto<List<Order>>>GetOrdersAsync(int productId);
         Task<ResponseDto<Order>>GetOrderAsync(int id);
         Task<ResponseDto<NoContent>>ChangeOrderStatusAsync(int id,OrderState orderState);
         Task<ResponseDto<NoContent>>CancelOrder(int id);
    }
}
