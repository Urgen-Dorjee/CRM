using CRM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain.Interfaces
{
    public interface ICustomerRepository : IRepositoryAsync<Customer>
    {
        Customer GetCustomerByEmailAddress(string email);
    }
}
