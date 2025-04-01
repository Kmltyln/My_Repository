using System;
using Microsoft.AspNetCore.Http;
using ShopApp.Shared.Dtos.ImageDtos;
using ShopApp.Shared.Helpers.Abstract;

namespace ShopApp.Shared.Helpers
{
    public class ImageHelper : IImageHelper
    {
        public Task<ImageDto> UploadImage(IFormFile image, string folderName)
        {
            throw new NotImplementedException();
        }
    }
}
