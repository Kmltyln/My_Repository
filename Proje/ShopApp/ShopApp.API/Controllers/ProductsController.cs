using System;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Business.Abstract;
using ShopApp.Shared.Helpers;

namespace ShopApp.API.Controllers;

public class ProductsController:CustomControllerBase
{
private readonly IProductService _productService;
}
public ProductsController(IProductService productService)
{
    _productService=productService;
}
[HttpGet]
public Task<IActionResult>CreateAsync() 