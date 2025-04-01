using System;
using Microsoft.AspNetCore.Http;

namespace ShopApp.Shared.Dtos.ImageDtos
{
    public class ImagesCreateDto
    {
        public IFormFile Image{get;set;}
        public string FolderName{get;set;}
    }
}
