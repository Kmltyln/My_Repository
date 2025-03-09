using System;
using ShopApp.Entity.Abstract;
namespace ShopApp.Entity.Concrete
{
    public class Product:BaseEntity
    {
        public string Properties {get;set;}
        public decimal Price {get;set;}
        public string ImageUrl{get;set;} 
        public bool IsHome{get;set;}
        public int CategoryId{get;set;} 
        public  Category Category{get;set;}
         
    }
}
