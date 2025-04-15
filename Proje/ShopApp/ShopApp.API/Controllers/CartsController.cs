using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Shared.Helpers;

namespace ShopApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartsController :CustomControllerBase
    {
        private readonly ICartService _cartService;
        private readonly ICartItemService _cartItemService;

        public CartsController(ICartService cartService, ICartItemService cartItemService)
        {
            _cartService = cartService;
            _cartItemService = cartItemService;
        }
        [HttpPost]
        public async Task<IActionResult>CreateCart(string userId)
        {
var response=await _cartService.InitilaizeCartAsync(userId);
return CreateActionResult(response);  
        }
        [HttpGet("{userId}")]
        public async Task<IActionResult>GetCart(string userId)
        {
        var response=await _cartService.GetCartByUserIdAsync(userId);
        return CreateActionResult(response);
        }
         [HttpPost]
        public async Task<IActionResult>AddToCart(string userId,int productId,int quantity)
        {
        var response=await _cartService.AddToCartAsync(userId,productId,quantity);
        return CreateActionResult(response);
    }
    [HttpPost]
      public async Task<IActionResult>ChangeQuantity(int cartItemId,int quantity)
        {
        var response=await _cartItemService.ChangeQuantityAsync(cartItemId,quantity);
        return CreateActionResult(response);
}
[HttpGet("{cartId}")]
public async Task<IActionResult>Count(int cartId)
{
    var response=await _cartItemService.CountAsync(cartId);
    return CreateActionResult(response);
}
[HttpDelete("{cartItemId}")]
public async Task<IActionResult>DeleteItem(int cartItemId)
{
    var response=await _cartItemService.DeleteCartItemAsync(cartItemId );
    return CreateActionResult(response);
}
[HttpDelete("{cartId}")]
public async Task<IActionResult>ClearCart(int cartId)
{
    var response=await _cartItemService.DeleteCartItemAsync(cartId );
    return CreateActionResult(response);
}
[HttpGet("{cartItemId}")]
public async Task<IActionResult>GetCartItem(int cartItemId)
{
    var response=await _cartItemService.GetCartItemAsync(cartItemId);
    return CreateActionResult(response);
}
}

}