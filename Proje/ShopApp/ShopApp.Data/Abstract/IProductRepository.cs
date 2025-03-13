using System;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data.Abstract;

public interface IProductRepository:IGenericRepository<Product>
{
//IGenericRepository'deki tüm metot imzaları Category için burada oluşturuldu,görünmüyor olmasına rağmen.
//Burada ise Category entity'sine özel metot imzalarımız yer alacak.

Task<List<Product>> GetProductsByCategoryIdAsync(int categoryId);
}
