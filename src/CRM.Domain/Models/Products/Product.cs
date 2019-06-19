using CRM.Core.Domain.BaseEntity;
using CRM.Domain.Models.Orders;
using CRM.Domain.Models.Vendors;
using System.Collections.Generic;

namespace CRM.Domain.Models.Products
{
    public class Product : Entity<int>
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string ProductName { get; private set; }
        public int? SupplierId { get; private set; }
        public int? CategoryId { get; private set; }
        public string QuantityPerUnit { get; private set; }
        public decimal? UnitPrice { get; private set; }
        public short? UnitsInStock { get; private set; }
        public short? UnitsOnOrder { get; private set; }
        public short? ReorderLevel { get; private set; }
        public bool Discontinued { get; private set; }

        public Category Category { get; set; }
        public Supplier Supplier { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; private set; }

        public Product(int productId, string productName, int? supplierId, int? categoryId,
                      string qtyPerUnit, decimal? unitPrice, short? inStock, short? onOrder,
                      short? orderLevel, bool discountinued)
        {
            Id = productId;
            ProductName = productName;
            SupplierId = supplierId;
            CategoryId = categoryId;
            QuantityPerUnit = qtyPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = inStock;
            UnitsOnOrder = onOrder;
            ReorderLevel = orderLevel;
            Discontinued = discountinued;
        }
    }
}
