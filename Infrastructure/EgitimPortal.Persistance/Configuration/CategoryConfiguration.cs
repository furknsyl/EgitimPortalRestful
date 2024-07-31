using EgitimPortal.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Xml.Linq;

namespace EgitimPortal.Persistance.Configuration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            Category category1 = new()
            {
                Id = 1,
                Name = "Yazılım",
                ParentId = 0,
                Priority = 1,
                IsDeleted = false,
                CreatedDate = DateTime.UtcNow,
            };
            Category category2 = new()
            {
                Id = 2,
                Name = "Dil",
                ParentId = 0,
                Priority = 2,
                IsDeleted = false,
                CreatedDate = DateTime.UtcNow,
            };
            Category parent1 = new()
            {
                Id = 3,
                Name = "C# Dersleri",
                ParentId = 1,
                Priority = 1,
                IsDeleted = false,
                CreatedDate = DateTime.UtcNow,
            };
            Category parent2 = new()
            {
                Id = 4,
                Name = "İngilizce",
                ParentId = 1,
                Priority = 2,
                IsDeleted = false,
                CreatedDate = DateTime.UtcNow,
            };
            builder.HasData(category1, category2,parent1,parent2);


        }


        
    }
}
