using System;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Shared.Dtos.CategoryDtos;
using ShopApp.Shared.Helpers;

namespace ShopApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]

public class CategoriesController:CustomControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpPost]
    public async Task<IActionResult> Create(CategoryCreateDto categoryCreateDto)
    {
    var response=await _categoryService.CreateAsync(categoryCreateDto);
     return CreateActionResult(response);
    }
}
}