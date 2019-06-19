using CRM.Core.Domain.Events;
using System;

namespace CRM.Domain.Customers.Commands.Command.DeleteCustomer
{
    public class DeletedCustomerEvent : Event
    {
        public Guid Id { get; private set; }
        public DeletedCustomerEvent(Guid id)
        {
            MessagesAggregate = id;
            Id = id;
        }
    }
}
