using System;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
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
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public ProductService(IProductRepository productRepository, IMapper mapper, ICategoryRepository categoryRepository)
    {
        _productRepository = productRepository;
        _mapper = mapper;
        _categoryRepository = categoryRepository;
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

    public async Task<ResponseDto<List<ProductDto>>> GetActivesAsync(bool isActive)
    {
         List<Product> productList=await _productRepository.GetAllAsync(null, x => x.Include(y => y.Category));;
        string statusText=isActive ? "aktif" : "pasif";
        if(productList.Count==0 )
        {
            return ResponseDto<List<ProductDto>>.Fail($"Hiç {statusText}ürün bulunamadı",StatusCodes.Status404NotFound); 
        }
        List<ProductDto> productDtosList= _mapper.Map<List<ProductDto>>(productList);
        return ResponseDto<List<ProductDto>>.Success(productDtosList ,StatusCodes.Status200OK);
    }

    public async Task<ResponseDto<int>> GetActivesCountAsync(bool isActive = true)
    {
       int count=await _productRepository.GetCountAsync(x=>x.IsActive==isActive);
       string statusText=isActive? "aktif":"pasif"; 
       if(count==0)
       {
        return ResponseDto<int>.Fail($"Hiç{isActive}kategori yok!",StatusCodes.Status404NotFound);
       }
       return ResponseDto<int>.Success(count,StatusCodes.Status200OK);
    }

    public async Task<ResponseDto<List<ProductDto>>> GetAllAsync()
    {
        List<Product>productList=await _productRepository.GetAllAsync(null,x=>x.Include(y=>y.Category));
        if(productList.Count==0)
        {
            return ResponseDto<List<ProductDto>>.Fail($"Hiç ürün bulunamadı",StatusCodes.Status404NotFound); 
        }
        List<ProductDto> productDtoList=_mapper.Map<List<ProductDto>>(productList);
        return ResponseDto<List<ProductDto>>.Success(productDtoList,StatusCodes.Status200OK);
    }

        public async Task<ResponseDto<List<ProductDto>>> GetAllByCategoryId(int categoryId)
    {
          List<Product>productList=await _productRepository.GetAllAsync(x=>x.IsActive==true && x.CategoryId==categoryId, x=>x.Include(y=>y.Category));
          var category=await _categoryRepository.GetByIdASync(x=>x.Id==categoryId);
          
        if(productList.Count==0)
        {
            return ResponseDto<List<ProductDto>>.Fail($"Hiç {category.Name}ürün bulunamadı",StatusCodes.Status404NotFound); 
        }
        List<ProductDto> productDtoList=_mapper.Map<List<ProductDto>>(productList);
        return ResponseDto<List<ProductDto>>.Success(productDtoList,StatusCodes.Status200OK);
    }

    public async Task<ResponseDto<ProductDto>> GetByIdAsync(int id)
    {
       Product product=await _productRepository.GetByIdASync(x=>x.Id==id,x=> x.Include(y=> y.Category));
          
          
        if(product==null)
        {
            return ResponseDto<List<ProductDto>>.Fail($"Hiç {category.Name}ürün bulunamadı",StatusCodes.Status404NotFound); 
        }
        ProductDto productDto=_mapper.Map<ProductDto>(product);
        return ResponseDto<List<ProductDto>>.Success(productDtoList,StatusCodes.Status200OK);
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
