using CRM.Core.Domain.BaseEntity;
using System.Collections.Generic;

namespace CRM.Domain.Models.Products
{
    public class Category : Entity<int>
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public string CategoryName { get; private set; }
        public string Description { get; private set; }
        public byte[] Picture { get; private set; }

        public ICollection<Product> Products { get; private set; }

        public Category(int categoryId, string categoryName, string description, byte[] picture)
        {
            Id = categoryId;
            CategoryName = categoryName;
            Description = description;
            Picture = picture;
        }
    }
}
