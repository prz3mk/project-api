using Ecom.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Infrastructure.Data.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(30);
            builder.Property(x => x.Price).HasColumnType("decimal(18, 2)");

            builder.HasData(
                new Product { Id = 5, Name = "Yeezy Gap Hoodie", Description = "Balenciaga x yeezy x gap hoodie", Price = 320, CategoryId = 3, ProductPicture = "/images/products/gap.png" },
                new Product { Id = 6, Name = "Jordan 1 Retro High", Description = "Jordan 1 retro's in collaboration with Fragment", Price = 2900, CategoryId = 2, ProductPicture = "/images/products/fragment.png" },
                new Product { Id = 7, Name = "Jordan 1 Retro High", Description = "Jordan 1's in Black Crimson Tint colorway", Price = 200, CategoryId = 1, ProductPicture = "/images/products/1s.png" },
                new Product { Id = 8, Name = "Nike Dunk Low Retro", Description = "Classic black&white dunks", Price = 100, CategoryId = 1, ProductPicture = "/images/products/whitedunks.png" },
                new Product { Id = 9, Name = "Nike Dunk Low Retro", Description = "Reverse black^&white dunks", Price = 190, CategoryId = 1, ProductPicture = "/images/products/dunks1.png" },
                new Product { Id = 10, Name = "Jordan 1 Retro Low", Description = "Jordan 1's in collaboration with Travis Scott", Price = 700, CategoryId = 2, ProductPicture = "/images/products/dunks2.png" },
                new Product { Id = 11, Name = "Jordan 1 Retro Low", Description = "Jordan 1's in collaboration with Travis Scott\"", Price = 800, CategoryId = 2, ProductPicture = "/images/products/travis.png" }
                           );
        }
    }
}
