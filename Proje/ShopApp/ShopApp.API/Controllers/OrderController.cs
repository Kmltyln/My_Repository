using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Helpers;

namespace ShopApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OrderController : CustomControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost]
        public async Task<IActionResult>AddOrder(Order order)
        {
            var response=await _orderService.CreateAsync(order);
            return CreateActionResult(response); 
        }
    }
}
