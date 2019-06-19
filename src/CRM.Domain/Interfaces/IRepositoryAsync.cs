using System;

namespace CRM.Domain.Interfaces
{
    public interface IRepositoryAsync<T> : IDisposable where T : class
    {
        void CreateCustomer(T entity);
        void DeleteCustomer(Guid id);
        void UpdateCustomer(T entity);
    }
}
