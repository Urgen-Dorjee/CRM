using CRM.Domain.Customers.Commands.Command.CreateCustomer;
using CRM.Domain.Customers.Commands.Command.DeleteCustomer;
using CRM.Domain.Customers.Commands.Command.UpdateCustomer;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Domain.Customers.Events
{
    public class CustomerEventHandler : INotificationHandler<CreatedCustomerEvent>,
                                        INotificationHandler<DeletedCustomerEvent>,
                                        INotificationHandler<UpdatedCustomerEvent>
    {
        public Task Handle(CreatedCustomerEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(DeletedCustomerEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task Handle(UpdatedCustomerEvent message, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
