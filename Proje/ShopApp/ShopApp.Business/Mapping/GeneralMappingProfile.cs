using System;
using AutoMapper;
using ShopApp.Entity.Concrete;
using ShopApp.Shared.Dtos.CategoryDtos;
namespace ShopApp.Business.Mapping
{
    public class GeneralMappingProfile:Profile 
    {
        public GeneralMappingProfile()
        {
            CreateMap<Category,CategoryDto>().ReverseMap();
            CreateMap<Category,CategoryCreateDto>().ReverseMap(); 
             CreateMap<Category,CategoryUpdateDto>().ReverseMap(); 
        }
    }
}
