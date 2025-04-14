using System;
using Microsoft.AspNetCore.Http;
using ShopApp.Business.Abstract;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Concrete
{
    public class OrderService : IOrderService
    
    { 
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public Task<ResponseDto<NoContent>> CancelOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(int id, OrderState orderState)
        {
            throw new NotImplementedException();
        }

        public async Task<ResponseDto<NoContent>> CreateAsync(Order order)
        {
           if(order==null)
           {
            return ResponseDto<NoContent>.Fail("Bir hata oluştu",StatusCodes.Status400BadRequest);
           }
        
        var orderResult=await _orderRepository.CreateAsync(order);
        if(orderResult==null)
        {
            return ResponseDto<NoContent>.Fail("Bir hata oluştu",StatusCodes.Status500InternalServerError);
        }
        return ResponseDto<NoContent>.Success(StatusCodes.Status201Created);
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
