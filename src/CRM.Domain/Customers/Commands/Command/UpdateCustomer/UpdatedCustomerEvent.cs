using CRM.Core.Domain.Events;
using System;

namespace CRM.Domain.Customers.Commands.Command.UpdateCustomer
{
    public class UpdatedCustomerEvent : Event
    {
        public Guid Id { get; private set; }
        public string CompanyName { get; private set; }
        public string ContactName { get; private set; }
        public string ContactTitle { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public string Phone { get; private set; }
        public string Fax { get; private set; }
        public string EmailAddress { get; private set; }
        public UpdatedCustomerEvent(Guid customerId, string company, string contact, string contactTitle, string address,
                      string city, string region, string post, string country, string phone, string fax, string email)
        {
            Id = customerId;
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
            EmailAddress = email;
        }
    }
}
