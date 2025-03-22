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
            category.Url=url;
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
           var category=await _categoryRepository.GetByIdASync(x=>x.Id==id);
           if(category==null)
           {
            return ResponseDto<NoContent>.Fail($"{id}id'li kategori bulunamadı",StatusCodes.Status404NotFound); 
           }
           await _categoryRepository.DeleteAsync(category);
           return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);  
        } 

        public Task<ResponseDto<List<CategoryDto>>> GetActiveAsync(bool isActive = true)
        {
          var categoryList=await _categoryRepository.GetAllAsync(x=>x.IsActive==isActive);
          string statusText=isActive? "aktif":"pasif";
          if(categoryList.Count==0)
          {
            return ResponseDto<List<CategoryDto>>.Fail($"Hiç {statusText}kategori bulunamadı!",StatusCodes.Status404NotFound);
          }
          var categoryDtoList=_mapper.Map<List<CategoryDto>>(categoryList);
          return ResponseDto<List<CategoryDto>>.Success(categoryDtoList,statusText);
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

