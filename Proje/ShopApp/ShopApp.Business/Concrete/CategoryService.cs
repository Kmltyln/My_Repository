using System;
using ShopApp.Business.Abstract;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.CategoryDtos;
using ShopApp.Shared.Dtos.ResponseDtos;
using ShopApp.Shared.Helpers;

namespace ShopApp.Business.Concrete
{
    public class CategoryService : ICategoryService
    {//Dependency Injection
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto)
        {
            string url = CustomUrlHelper.GetUrl(categoryCreateDto.Name);
            Category category =new Category
            {
            Name=categoryCreateDto.Name,
            Description=categoryCreateDto.Description,
            IsActive=categoryCreateDto.IsActive,
            Url=url
            };
            var createdCategory=await _categoryRepository.CreateAsync(category);
            if(createdCategory==null)
            {
                return ResponseDto<CategoryDto>.Fail("Bir hata oluştu",StatusCodes.Status400BadRequest); 
            }
           
        }

        public Task<ResponseDto<NoContent>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<CategoryDto>>> GetActiveAsync(bool isActive = true)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<int>> GetActivesCountAsync(bool isActive = true)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<List<CategoryDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<CategoryDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<int>> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<CategoryDto>> UpdateAsync(CategoryUpdateDto categoryUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}

