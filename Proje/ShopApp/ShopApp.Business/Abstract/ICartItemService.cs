using System;
using Microsoft.AspNetCore.Http.HttpResults;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ResponseDtos;
using NoContent = ShopApp.Shared.Dtos.ResponseDtos.NoContent;
namespace ShopApp.Business.Abstract
{
    public interface ICartItemService
    {
Task<ResponseDto<NoContent>>ChangeQuantityAsync(int cartItemId,int quantity);
Task<ResponseDto<int>>CountAsync(int cartId);
Task<ResponseDto<NoContent>>DeleteCartItemAsync(int cartItemId);

Task<ResponseDto<NoContent>>ClearCartAsync(int cartId);
Task<ResponseDto<CartItem>>GetCartItemAsync(int cartItemId);
    }
}
