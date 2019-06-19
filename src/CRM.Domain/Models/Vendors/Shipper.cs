using CRM.Core.Domain.BaseEntity;
using CRM.Domain.Models.Orders;
using System.Collections.Generic;

namespace CRM.Domain.Models.Vendors
{
    public class Shipper : Entity<int>
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }

        public string CompanyName { get; private set; }
        public string Phone { get; private set; }

        public ICollection<Order> Orders { get; private set; }
        public Shipper(int shipperId, string companyName, string phone)
        {
            Id = shipperId;
            CompanyName = companyName;
            Phone = phone;
        }
    }
}
