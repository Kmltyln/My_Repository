using System;
using AutoMapper;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.CategoryDtos;
using ShopApp.Shared.Dtos.OrderDtos;
using ShopApp.Shared.Dtos.ProductDtos;
namespace ShopApp.Business.Mapping
{
    public class GeneralMappingProfile:Profile 
    {
        public GeneralMappingProfile()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category,CategoryCreateDto>().ReverseMap(); 
             CreateMap<Category,CategoryUpdateDto>().ReverseMap(); 

             CreateMap<Product,ProductDto>().ReverseMap();
             CreateMap<Product,ProductDto>().ReverseMap();
             CreateMap<Product,ProductDto>().ReverseMap(); 

             CreateMap<OrderItem, OrderItemDto>().ReverseMap();
             CreateMap<OrderItem, OrderItemCreateDto>().ReverseMap();


             
              CreateMap<Order, InOrderItemOrderDto>().ReverseMap();
              CreateMap<Order, OrderDto>().ReverseMap();
             CreateMap<Order, OrderCreateDto>().ReverseMap();
        }
    }
}
