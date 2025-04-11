using System.Reflection.Metadata.Ecma335;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Shared.Helpers;

namespace ShopApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CartController :CustomControllerBase
    {
        private readonly ICartService _cartService;
        private readonly ICartItemService _cartItemService;

        public CartController(ICartService cartService, ICartItemService cartItemService)
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
        [HttpGet]
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
}
}
