using System;
using Microsoft.AspNetCore.Http;
using ShopApp.Shared.Dtos.ImageDtos;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Shared.Helpers.Abstract
{
    public interface IImageHelper
    {
    Task<ResponseDto<ImageDto>> UploadImageAsync(ImageCreateDto imageCreateDto);
    ResponseDto<NoContent>DeleteImage(ImageDeleteDto imageDeleteDto);
    
    }
}
