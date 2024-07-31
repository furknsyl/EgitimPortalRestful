using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EgitimPortal.Domain.Entities;
using Bogus;

namespace EgitimPortal.Persistance.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Faker faker = new("tr");

            Product product1 = new()
            {
                Id = 1,
                title =faker.Commerce.ProductName(),
                description=faker.Commerce.ProductDescription(),
                price =faker.Finance.Amount(100,1000),
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false,
                
            };

            Product product2 = new()
            {
                Id = 2,
                title = faker.Commerce.ProductName(),
                description = faker.Commerce.ProductDescription(),
                price = faker.Finance.Amount(100, 1000),
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false,

            };
            builder.HasData(product1,product2);
        }
    }
}
