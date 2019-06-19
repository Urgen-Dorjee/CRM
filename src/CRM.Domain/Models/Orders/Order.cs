using CRM.Core.Domain.BaseEntity;
using CRM.Domain.Models.Employees;
using CRM.Domain.Models.Vendors;
using System;
using System.Collections.Generic;

namespace CRM.Domain.Models.Orders
{
    public class Order : Entity<int>
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string CustomerId { get; private set; }
        public int? EmployeeId { get; private set; }
        public DateTimeOffset? OrderDate { get; private set; }
        public DateTimeOffset? RequiredDate { get; private set; }
        public DateTimeOffset? ShippedDate { get; private set; }
        public int? ShipVia { get; private set; }
        public decimal? Freight { get; private set; }
        public string ShipName { get; private set; }
        public string ShipAddress { get; private set; }
        public string ShipCity { get; private set; }
        public string ShipRegion { get; private set; }
        public string ShipPostalCode { get; private set; }
        public string ShipCountry { get; private set; }

        public Customer Customer { get; private set; }
        public Employee Employee { get; private set; }
        public Shipper Shipper { get; private set; }
        public ICollection<OrderDetail> OrderDetails { get; private set; }

        public Order(int orderId, string customerId, int? employeeId,DateTimeOffset? orderDate, DateTimeOffset? requireDate,
                    DateTimeOffset? shipDate, int? shipvia, decimal? freight, string shipname,
                    string shipAdd, string shipCity, string shipRegion, string shipPostal, string shipCountry)
        {
            Id = orderId;
            CustomerId = customerId;
            EmployeeId = employeeId;
            OrderDate = orderDate;
            RequiredDate = requireDate;
            ShippedDate = shipDate;
            ShipVia = shipvia;
            Freight = freight;
            ShipName = shipname;
            ShipAddress = shipAdd;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostal;
            ShipCountry = shipCountry;
        }
    }
}
