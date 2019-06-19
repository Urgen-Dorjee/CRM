using CRM.Core.Domain.BaseEntity;
using CRM.Domain.Models.Products;
using System.Collections.Generic;

namespace CRM.Domain.Models.Vendors
{
    public class Supplier : Entity<int>
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HomePage { get; set; }

        public ICollection<Product> Products { get; private set; }

        public Supplier(int supplierId, string company, string contact, string contactTitle, string address,
                       string city, string region, string post, string country, string phone, string fax,
                       string homePage)
        {
            Id = supplierId;
            CompanyName = company;
            ContactName = contact;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = post;
            Country = country;
            Phone = phone;
            Fax = fax;
            HomePage = homePage;
        }
    }
}
