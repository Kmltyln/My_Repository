using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.OrderDtos;
using ShopApp.Shared.Helpers;

namespace ShopApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrdersController : CustomControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public async Task<IActionResult>AddOrder(OrderCreateDto orderCreateDto)
        {
            var response=await _orderService.CreateAsync(orderCreateDto);
            return CreateActionResult(response); 
        }
        [HttpGet("{id}")]
          public async Task<IActionResult>GetOrder(int id)
        {
            var response=await _orderService.GetOrderAsync(id);
            return CreateActionResult(response); 
        } 
    }
}
