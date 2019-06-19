using CRM.Core.Domain.BaseEntity;
using CRM.Domain.Models.Orders;
using System;
using System.Collections.Generic;

namespace CRM.Domain.Models.Employees
{
    public class Employee : Entity<int>
    {
        public Employee()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritory>();
            DirectReports = new HashSet<Employee>();
            Orders = new HashSet<Order>();
        }
        public Employee Manager { get; set; }
        public ICollection<EmployeeTerritory> EmployeeTerritories { get; set; }
        public ICollection<Employee> DirectReports { get; private set; }
        public ICollection<Order> Orders { get; private set; }

        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Title { get; private set; }
        public string TitleOfCourtesy { get; private set; }
        public DateTimeOffset? BirthDate { get; private set; }
        public DateTimeOffset? HireDate { get; private set; }
        public string Address { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string PostalCode { get; private set; }
        public string Country { get; private set; }
        public string HomePhone { get; private set; }
        public string Extension { get; private set; }
        public byte[] Photo { get; private set; }
        public string Notes { get; private set; }
        public int? ReportsTo { get; private set; }
        public string PhotoPath { get; private set; }
        public Employee(int employeeId, string lastName, string firstName,string title, string titleCourtesy,
                       DateTimeOffset? birth, DateTimeOffset? hire, string add, string city, string region,
                       string postal, string country, string home, string ext, byte[] photo, string notes,
                       int? report, string photoPath)
        {
            Id = employeeId;
            LastName = lastName;
            FirstName = firstName;
            Title = title;
            TitleOfCourtesy = titleCourtesy;
            BirthDate = birth;
            HireDate = hire;
            Address = add;
            City = city;
            Region = region;
            PostalCode = postal;
            Country = country;
            HomePhone = home;
            Extension = ext;
            Photo = photo;
            Notes = notes;
            ReportsTo = report;
            PhotoPath = photoPath;
        }
    }
}
