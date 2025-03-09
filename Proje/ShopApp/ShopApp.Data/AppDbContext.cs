using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data
{
    public class AppDbContext:DbContext 
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
