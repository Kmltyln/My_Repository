using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopApp.Entity.Concrete;

namespace ShopApp.Data.Concrete.Configs
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Url)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(x => x.Description)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(x => x.CreatedDate)
                .HasDefaultValueSql("getdate()");
            builder.Property(x => x.ModifiedDate)
                .HasDefaultValueSql("getdate()");

            List<Category> categories = [
                new(){
                    Id=1,
                    Name="Genel",
                    Description="Genel kategori",
                    IsActive=true,
                    Url="genel"
                },
                new(){
                    Id=2,
                    Name="Telefon",
                    Description="Telefonlar",
                    IsActive=true,
                    Url="telefon"
                },
                new(){
                    Id=3,
                    Name="Elektronik",
                    Description="Elektronik ürünler",
                    IsActive=true,
                    Url="elektronik"
                },
                new(){
                    Id=4,
                    Name="Bilgisayar",
                    Description="Bilgisayarlar",
                    IsActive=true,
                    Url="bilgisayar"
                },
                new(){
                    Id=5,
                    Name="Beyaz Eşya",
                    Description="Beyaz Eşyalar",
                    IsActive=true,
                    Url="beyaz-esya"
                },
                new(){
                    Id=6,
                    Name="Yurt Dışı",
                    Description="Yurt dışından gelen ürünler",
                    IsActive=false,
                    Url="yurt-disi"
                }
            ];
            builder.HasData(categories);
            builder.ToTable("Categories");
        }
    }
}
