using System;
using System.Runtime.ConstrainedExecution;
using Microsoft.EntityFrameworkCore;
using ShopApp.Data.Concrete.Configs;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data
{
    public class AppDbContext:DbContext 
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts{get;set;}
        public DbSet<CartItem> CartItems{get;set;}
        public DbSet<Order> Orders {get;set;}

        public DbSet<Order>Carts MyProperty { get; set; }
        public DbSet<OrderItem>CartItems MyProperty { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(CategoryConfig).Assembly);
           base.OnModelCreating(modelBuilder);
        }
    }
}
 