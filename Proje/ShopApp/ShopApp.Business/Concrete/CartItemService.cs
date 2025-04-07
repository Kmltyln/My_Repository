using System;
using ShopApp.Business.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Concrete
{
    public class CartItemService : ICartItemService
    {
        public Task<ResponseDto<NoContent>> ChangeQuantityAsync(int cartItemId, int quantity)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<NoContent>> ClearCartAsync(int cartId)
        {
            throw new NotImplementedException();
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
