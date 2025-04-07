using System;
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

        public Task<ResponseDto<Cart>> AddToCartAsync(string userId, int productId, int quantity)
        {
            throw new NotImplementedException();
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
