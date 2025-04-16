using System;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<NoContent>> CancelOrderAsync(int id)
        {
            var order = await _orderRepository.GetASync(x => x.Id == id);
            if (order == null)
            {
                return ResponseDto<NoContent>.Fail("Böyle bir sipariş bulunamadı!", StatusCodes.Status404NotFound);
            }
            await _orderRepository.DeleteAsync(order);
            return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<NoContent>> ChangeOrderStatusAsync(int id, OrderState orderState)
        {
            var order = await _orderRepository.GetASync(x => x.Id == id);
            if (order == null)
            {
                return ResponseDto<NoContent>.Fail("Böyle bir sipariş bulunamadı!", StatusCodes.Status404NotFound);
            }
            order.OrderState = orderState;
            await _orderRepository.UpdateAsync(order);
            return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<NoContent>> CreateAsync(OrderCreateDto orderCreateDto)
        {
            if (orderCreateDto == null)
            {
                return ResponseDto<NoContent>.Fail("Bir hata oluştu", StatusCodes.Status400BadRequest);
            }
            var order = _mapper.Map<Order>(orderCreateDto);
            var orderResult = await _orderRepository.CreateAsync(order);
            if (orderResult == null)
            {
                return ResponseDto<NoContent>.Fail("Bir hata oluştu", StatusCodes.Status500InternalServerError);
            }
            return ResponseDto<NoContent>.Success(StatusCodes.Status201Created);
        }

        public async Task<ResponseDto<OrderDto>> GetOrderAsync(int id)
        {
            var order = await _orderRepository.GetASync(x => x.Id == id, source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));
            if (order == null)
            {
                return ResponseDto<OrderDto>.Fail("Böyle bir sipariş bulunamadı!", StatusCodes.Status404NotFound);
            }
            var orderDto = _mapper.Map<OrderDto>(order);
            return ResponseDto<OrderDto>.Success(orderDto, StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<List<OrderDto>>> GetOrdersAsync()
        {
            var orders = await _orderRepository.GetAllAsync(null, source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));
            if (orders.Count == 0)
            {
                return ResponseDto<List<OrderDto>>.Fail("Hiç sipariş bulunamadı!", StatusCodes.Status404NotFound);
            }
            var orderDtoList = _mapper.Map<List<OrderDto>>(orders);
            return ResponseDto<List<OrderDto>>.Success(orderDtoList, StatusCodes.Status200OK);
        }

        public async Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(string userId)
        {
            var orders = await _orderRepository.GetAllAsync(x => x.UserId == userId, source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));
            if (orders.Count == 0)
            {
                return ResponseDto<List<OrderDto>>.Fail("Hiç sipariş bulunamadı!", StatusCodes.Status404NotFound);
            }
            var orderDtoList = _mapper.Map<List<OrderDto>>(orders);
            return ResponseDto<List<OrderDto>>.Success(orderDtoList, StatusCodes.Status200OK);
        }
        // x => x.OrderItems.Any(y => y.ProductId == productId
        public async Task<ResponseDto<List<OrderDto>>> GetOrdersAsync(int productId)
        {
            var orders = await _orderRepository.GetAllAsync(x => x.OrderItems.Any(y => y.ProductId == productId), source => source.Include(x => x.OrderItems).ThenInclude(y => y.Product));
            if (orders.Count == 0)
            {
                return ResponseDto<List<OrderDto>>.Fail("Hiç sipariş bulunamadı!", StatusCodes.Status404NotFound);
            }
            var orderDtoList = _mapper.Map<List<OrderDto>>(orders);
            return ResponseDto<List<OrderDto>>.Success(orderDtoList, StatusCodes.Status200OK);
        }
    }
}
