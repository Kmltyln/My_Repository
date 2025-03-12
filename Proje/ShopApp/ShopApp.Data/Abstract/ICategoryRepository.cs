using System;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data.Abstract;

public interface ICategoryRepository:IGenericRepository<Category>
{
//IGenericRepository'deki tüm metod imzaları Category için burada oluşturuldu,görünmüyor olmasına rağmen.
//Burada ise Category entity'sine ait özel metod imzalarımız yer alacak. 
}
