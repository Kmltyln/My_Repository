using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ShopApp.Business.Abstract;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Concrete
{
    public class CartItemService : ICartItemService
    {

        private readonly ICartItemRepository _cartItemRepository;
        private readonly ICartRepository _cartRepository;

        public CartItemService(ICartItemRepository cartItemRepository, ICartRepository cartRepository)
        {
            _cartItemRepository = cartItemRepository;
            _cartRepository = cartRepository;
        }

        public async Task<ResponseDto<NoContent>> ChangeQuantityAsync(int cartItemId, int quantity)
        {
            var cartItem=await _cartItemRepository.GetASync(x=>x.Id==cartItemId);
            if(cartItem==null)
            {
                return ResponseDto<NoContent>.Fail("İlgili ürün sepette bulunamadı!",StatusCodes.Status404NotFound);
            }
            cartItem.Quantity=quantity;
            await _cartItemRepository.UpdateAsync(cartItem);
            return ResponseDto<NoContent>.Success(StatusCodes.Status200OK); 
        }

        public async Task<ResponseDto<NoContent>> ClearCartAsync(int cartId)
        {
             var cart=await _cartRepository.GetASync(x=>x.Id==cartId,source=>source.Include(x=>x.CartItems));
            if(cart==null)
            {
                return ResponseDto<NoContent>.Fail("İlgili ürün sepette bulunamadı!",StatusCodes.Status404NotFound);
            }
            cart.CartItems.Clear();
            await _cartRepository.UpdateAsync(cart);
            return ResponseDto<NoContent>.Success(); 

        }

        public Task<ResponseDto<int>> CountAsync(int cartId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> DeleteCartItemAsync(int cartItemId)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<CartItem>> GetCartItemAsync(int cartItemId)
        {
            throw new NotImplementedException();
        }
    }
}
