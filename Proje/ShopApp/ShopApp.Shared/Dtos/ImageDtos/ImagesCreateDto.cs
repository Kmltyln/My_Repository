using System;
using Microsoft.AspNetCore.Http;

namespace ShopApp.Shared.Dtos.ImageDtos
{
    public class ImageCreateDto
    {
        public IFormFile Image{get;set;}
        public string FolderName{get;set;}
    }
}
