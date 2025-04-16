using System;
using ShopApp.Shared.Dtos.ProductDtos;

namespace ShopApp.Shared.Dtos.OrderDtos;

public class OrderItemDto
{
  public int Id{get;set;}
    public int OrderId{get;set;}
    public InOrderItemOrderDto Order { get; set; }
  
    public int ProductId{get;set;}
    public ProductDto Product{get;set;}
    public decimal Price{get;set;}
    public int Quantity{get;set;}
}
