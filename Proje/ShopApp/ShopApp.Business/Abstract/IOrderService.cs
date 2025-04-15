using System;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.OrderDtos;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Abstract
{
    public interface IOrderService
    {
        Task<ResponseDto<NoContent>>CreateAsync(OrderCreateDto orderCreateDto);
        Task<ResponseDto<List<OrderDto>>>GetOrdersAsync();
         Task<ResponseDto<List<OrderDto>>>GetOrdersAsync(string userId);
         Task<ResponseDto<List<OrderDto>>>GetOrdersAsync(int productId);
         Task<ResponseDto<OrderDto>>GetOrderAsync(int id);
         Task<ResponseDto<NoContent>>ChangeOrderStatusAsync(int id,OrderState orderState);
         Task<ResponseDto<NoContent>>CancelOrder(int id);
    }
}
