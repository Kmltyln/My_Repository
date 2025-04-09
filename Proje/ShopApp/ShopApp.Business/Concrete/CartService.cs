using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http;
using ShopApp.Business.Abstract;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Concrete
{
    public class CartService : ICartService
    {
        private readonly ICartRepository _cartRepository;

        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public async Task<ResponseDto<NoContent>> AddToCartAsync(string userId, int productId, int quantity)
        {
            Cart cart=await _cartRepository.GetASync(x=>x.UserId==userId);
            if(cart == null)
            {
                return ResponseDto<NoContent>.Fail("Kullanıcıya ait bir sepet bulunamadı!",StatusCodes.Status404NotFound);
            }
            var index=cart.CartItems.FindIndex(x=>x.ProductId==productId);
            for(int i=0;i<cart.CartItems.Count;i++)
            {
                if(cart.CartItems[i].ProductId==productId)

                {
                    index=i;
                    break;
                }
            }
            await _cartRepository.UpdateAsync(cart);
            return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
        }

        public Task<ResponseDto<Cart>> GetCartByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> InitilaizeCartAsync(string userId)
        {
            throw new NotImplementedException();
        }

    
    }
}
