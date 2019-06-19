using CRM.Core.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain.Orders.Commands.Command
{
    public abstract class OrderCommand : CoreCommand
    {        
        public int OrderId { get; private set; }
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

        //public Customer Customer { get; private set; }
        //public Employee Employee { get; private set; }
        //public Shipper Shipper { get; private set; }
        //public ICollection<OrderDetail> OrderDetails { get; private set; }

        public OrderCommand(int orderId, string customerId, int? employeeId, DateTimeOffset? orderDate, DateTimeOffset? requireDate,
                    DateTimeOffset? shipDate, int? shipvia, decimal? freight, string shipname,
                    string shipAdd, string shipCity, string shipRegion, string shipPostal, string shipCountry)
        {
            OrderId = orderId;
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
