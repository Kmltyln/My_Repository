using System;
using ShopApp.Shared.Dtos.CategoryDtos;


namespace ShopApp.Business.Abstract;

public interface ICategoryService
{
Task<List<CategoryDto>> GetAll();
}
