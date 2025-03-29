 using System;
using ShopApp.Shared.Dtos.ProductDtos;
using ShopApp.Shared.Dtos.ResponseDtos;

namespace ShopApp.Business.Abstract;

public interface IProductService
{
Task<ResponseDto<ProductDto>> CreateAsync(ProductCreateDto productCreateDto);
Task<ResponseDto<ProductDto>> UpdateAsync(ProductUpdateDto productUpdateDto);
Task<ResponseDto<NoContent>> DeleteAsync(int id);
Task<ResponseDto<ProductDto>> GetByIdAsync(int id);
Task<ResponseDto<List<ProductDto>>> GetAllAsync();
Task<ResponseDto<List<ProductDto>>> GetActivesAsync(bool isActive);
Task<ResponseDto<List<ProductDto>>> GetHomeAsync(bool isHome=true);  
Task<ResponseDto<List<ProductDto>>> GetAllByCategoryAsync(int categoryId);
Task<ResponseDto<int>>GetCountAsync();
Task<ResponseDto<int>>GetActivesCountAsync(bool isActive=true);
Task<ResponseDto<int>>GetHomeCountAsync(bool isHome=true);
Task<ResponseDto<NoContent>> UpdateIsActiveAsync(int id);
Task<ResponseDto<NoContent>>UpdateIsHomeAsync(int id); 
}
