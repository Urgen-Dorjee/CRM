using CRM.Core.Domain.Events;

namespace CRM.Domain.Customers.Commands.Command.DeleteCustomer
{
    public class DeletedCustomerEvent : Event
    {
        public string Id { get; private set; }
        public DeletedCustomerEvent(string id)
        {
            MessagesAggregate = id;
            Id = id;
        }
    }
}
