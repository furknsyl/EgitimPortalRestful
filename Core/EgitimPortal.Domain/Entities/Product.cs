using EgitimPortal.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimPortal.Domain.Entities
{
    public class Product:EntityBase
    {
        public Product()
        {
                
        }
        public Product(string Title, string Description, decimal Price)
        {
            title = Title;
            description = Description;
            price = Price;

        }

        public  string title { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
