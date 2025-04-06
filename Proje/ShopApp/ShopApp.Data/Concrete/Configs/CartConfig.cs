using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data.Concrete.Configs;

public class CartConfig : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.HasData(
            new Cart{Id=1,CreatedDate=DateTime.Now, UserId="1"}
        );      
    }
}
