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
     [HttpPost]
    public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
    {
    var response=await _categoryService.UpdateAsync(categoryUpdateDto);
     return CreateActionResult(response);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult>Delete(int id)
    { 
    var response=await _categoryService.DeleteAsync(id);
    return CreateActionResult(response);
    }
[HttpGet]
public async Task<IActionResult> GetActives(bool isActive=true)
{
    var response=await _categoryService.GetActivesAsync(isActive);
    return CreateActionResult(response);
}
[HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryService.GetAllAsync();
            return CreateActionResult(response);
        }

[HttpGet("{isActive}")]
public async Task<IActionResult> GetActivesCount(bool isActive=true)
{
    var response=await _categoryService.GetActivesCountAsync(isActive);
    return CreateActionResult(response);
}
[HttpGet]
public async Task<IActionResult> GetCount()
{
    var response=await _categoryService.GetCountAsync( );
    return CreateActionResult(response);
}
    }
}