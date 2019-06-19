using CRM.Core.Domain.BaseEntity;
using CRM.Domain.Models.Products;

namespace CRM.Domain.Models.Orders
{
    public class OrderDetail
    {
        public int OrderId { get; private set; }
        public int ProductId { get; private set; }
        public decimal UnitPrice { get; private set; }
        public short Quantity { get; private set; }
        public float Discount { get; private set; }

        public Order Order { get; set; }
        public Product Product { get; set; }

        public OrderDetail(int orderId, int productId, decimal unitPrice, short quantity, float discount)
        {
            OrderId = orderId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }
    }
}
