﻿using CRM.Core.Domain.BaseEntity;
using CRM.Domain.Models.Orders;
using System;
using System.Collections.Generic;

namespace CRM.Domain.Models
{
    public class Customer : Entity<Guid>
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

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

        public ICollection<Order> Orders { get; private set; }

        public Customer(Guid customerId, string company, string contact, string contactTitle, string address,
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
