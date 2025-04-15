using System;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ShopApp.Business.Abstract;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.OrderDtos;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Concrete
{
    public class OrderService : IOrderService
    
    { 
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public OrderService(IOrderRepository orderRepository,IMapper mapper)
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

        public async Task<ResponseDto<NoContent>> CreateAsync(OrderCreateDto orderCreateDto)
        {
           if(orderCreateDto==null)
           {
            return ResponseDto<NoContent>.Fail("Bir hata oluştu",StatusCodes.Status400BadRequest);
           }
        var order=_mapper.Map<Order>(orderCreateDto);
        var orderResult=await _orderRepository.CreateAsync(order);
        if(orderResult==null)
        {
            return ResponseDto<NoContent>.Fail("Bir hata oluştu",StatusCodes.Status500InternalServerError);
        }
        return ResponseDto<NoContent>.Success(StatusCodes.Status201Created);
        }
         public async Task<ResponseDto<OrderDto>> GetOrderAsync(int id)
        {
           var order=await _orderRepository.GetASync(x=>x.Id==id); 
           if(order==null)
           {
            return ResponseDto<OrderDto>.Fail("Böyle bir sipariş bulunamadı",StatusCodes.Status404NotFound);
           }
           var orderDto= _mapper.Map<OrderDto>(order);
           return ResponseDto<OrderDto>.Success(orderDto,StatusCodes.Status200OK);
        }

        public Task<ResponseDto<List<OrderDto>>> GetOrdersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(int productId)
        {
            throw new NotImplementedException();
        }

        Task<ResponseDto<OrderDto>> IOrderService.GetOrderAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
