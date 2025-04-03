using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Shared.Dtos.ImageDtos;
using ShopApp.Shared.Helpers;
using ShopApp.Shared.Helpers.Abstract;

namespace ShopApp.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImagesController : CustomControllerBase
    {
        private readonly IImageHelper _imageHelper;

        public ImagesController(IImageHelper imageHelper)
        {
            _imageHelper = imageHelper;
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(ImageCreateDto imageCreateDto)
        {
            var response = await _imageHelper.UploadImageAsync(imageCreateDto);
            return CreateActionResult(response);
        }

       
    }
}
