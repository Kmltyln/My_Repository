using System;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using ShopApp.Business.Abstract;
using ShopApp.Data.Abstract;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.ProductDtos;
using ShopApp.Shared.Dtos.ResponseDtos;
using ShopApp.Shared.Helpers;

namespace ShopApp.Business.Concrete;

public class ProductService : IProductService
{

    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public async Task<ResponseDto<ProductDto>> CreateAsync(ProductCreateDto productCreateDto)
    {
        Product product=_mapper.Map<Product>(productCreateDto);
        product.Url=CustomUrlHelper.GetUrl(productCreateDto.Name);
        var createdProduct=await _productRepository.CreateAsync(product);
        if(createdProduct==null)
        {
            return ResponseDto<ProductDto>.Fail("Bir hata oluştu",StatusCodes.Status400BadRequest);
        }
        ProductDto createdProductDto=_mapper.Map<ProductDto>(createdProduct);
        return ResponseDto<ProductDto>.Success(createdProductDto,StatusCodes.Status201Created);
    }

    public async Task<ResponseDto<NoContent>> DeleteAsync(int id)
    {
       Product product=await _productRepository.GetByIdASync(x=>x.Id==id);
       if(product==null)
       {
        return ResponseDto<NoContent>.Fail($"{id}id'li ürün bulunamadı",StatusCodes.Status404NotFound );
       }
       await _productRepository.DeleteAsync(product);
       return ResponseDto<NoContent>.Success(StatusCodes.Status200OK);
    }

    public Task<ResponseDto<List<ProductDto>>> GetActivesAsync(bool isActive)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<int>> GetActivesCountAsync(bool isActive = true)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<List<ProductDto>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<List<ProductDto>>> GetByCategoryAsync(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<ProductDto>> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<int>> GetCountAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<List<ProductDto>>> GetHomeAsync(bool isHome = true)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<int>> GetHomeCountAsync(bool isActive = true)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<ProductDto>> UpdateAsync(ProductUpdateDto productUpdateDto)
    {
        throw new NotImplementedException();
    }

    public Task<ResponseDto<NoContent>> UpdateIsActiveAsync(int id)
    {
        throw new NotImplementedException();
    }
}
