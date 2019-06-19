using CRM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM.Domain.Interfaces
{
    public interface IRepositoryAsync<T> : IDisposable where T : class
    {
        void CreateCustomer(T entity);
    }
}
