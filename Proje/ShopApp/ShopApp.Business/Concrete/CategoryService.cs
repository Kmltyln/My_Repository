using System;
using AutoMapper;
using Microsoft.AspNetCore.Http;
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
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<ResponseDto<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto)
        {
            string url = CustomUrlHelper.GetUrl(categoryCreateDto.Name);
            Category category =_mapper.Map<Category>(categoryCreateDto);
            
            var createdCategory=await _categoryRepository.CreateAsync(category);
            if(createdCategory==null)
            {
                return ResponseDto<CategoryDto>.Fail("Bir hata oluştu",StatusCodes.Status400BadRequest); 
            }
           CategoryDto categoryDto=_mapper.Map<CategoryDto>(createdCategory);
           
           return ResponseDto<CategoryDto>.Success(categoryDto,StatusCodes.Status201Created);
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

