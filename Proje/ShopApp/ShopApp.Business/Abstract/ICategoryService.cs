using System;
using ShopApp.Shared.Dtos.CategoryDtos;
using ShopApp.Shared.Dtos.ResponseDtos;


namespace ShopApp.Business.Abstract;

public interface ICategoryService
{
Task <ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto)  ;
Task<ResponseDto<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
Task<ResponseDto<NoContent>> DeleteAsync(int id);
Task<ResponseDto<CategoryDto>> GetByIdAsync(int id);
Task<ResponseDto<List<CategoryDto>>>GetAllAsync();
Task<ResponseDto<List<CategoryDto>>>GetActiveAsync(bool isActive=true);
Task<ResponseDto<int>>GetCountAsync();
Task<ResponseDto<int>>GetActivesCountAsync(bool isActive=true);

}
