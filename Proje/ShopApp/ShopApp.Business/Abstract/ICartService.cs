using System;
using Microsoft.AspNetCore.Http.HttpResults;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ResponseDtos;
using NoContent = ShopApp.Shared.Dtos.ResponseDtos.NoContent;

namespace ShopApp.Business.Abstract
{
    public interface ICartService
    {
Task<ResponseDto<NoContent>> InitilaizeCartAsync(string userId);
Task<ResponseDto<Cart>> GetCartByUserIdAsync(string userId);
Task<ResponseDto<NoContent>>AddToCartAsync(string userId,int productId,int quantity);
    }
}
