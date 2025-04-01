using System;
using Microsoft.AspNetCore.Http;
using ShopApp.Shared.Dtos.ImageDtos;

namespace ShopApp.Shared.Helpers.Abstract
{
    public interface IImageHelper
    {
    Task<ImageDto> UploadImage(IFormFile image,string folderName);
    }
}
