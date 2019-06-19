using CRM.Core.Domain.Bus;
using CRM.Core.Domain.Notifications;
using CRM.Domain.Customers.Commands.Command.CreateCustomer;
using CRM.Domain.Customers.Commands.Command.DeleteCustomer;
using CRM.Domain.Customers.Commands.Command.UpdateCustomer;
using CRM.Domain.Interfaces;
using CRM.Domain.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Domain.Customers.Commands.ComandHandlers
{
    public class CustomerCommandHandler : CommandHandler, IRequestHandler<CreateCustomerCommand, bool>,
                                          IRequestHandler<DeleteCustomerCommand, bool>,
                                          IRequestHandler<UpdateCustomerCommand, bool>
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMediatorHandler _bus;

        public CustomerCommandHandler(IMediatorHandler bus, INotificationHandler<CRMCoreNotification> notification,
                                     IUnitOfWork unit,
                                     ICustomerRepository customerRepository) : base(bus, notification, unit)
        {
            _customerRepository = customerRepository;
            _bus = bus;
        }
        public async Task<bool> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsInValidState())
            {
                NotifyValidationErrors(request);
                return await Task.FromResult(false);
            }
            var customer = new Customer(Guid.NewGuid(), request.CompanyName, request.ContactName,
                               request.ContactTitle, request.Address, request.City, request.Region,
                               request.PostalCode, request.Country, request.Phone, request.Fax, request.EmailAddress);
            if (_customerRepository.GetCustomerByEmailAddress(request.EmailAddress) != null)
            {
                await _bus.RaiseEvent(new CRMCoreNotification(request.MessageType, "This email has already registered with us, try again..."));
                return await Task.FromResult(false);
            }
            _customerRepository.CreateCustomer(customer);
            if(await Commit())
            {
                await _bus.RaiseEvent(new CreatedCustomerEvent(request.Id, request.CompanyName, request.ContactName,
                               request.ContactTitle, request.Address, request.City, request.Region,
                               request.PostalCode, request.Country, request.Phone, request.Fax, request.EmailAddress));
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsInValidState())
            {
                NotifyValidationErrors(request);
                return await Task.FromResult(false);
            }
            _customerRepository.DeleteCustomer(request.Id);
            if(await Commit())
            {
                await _bus.RaiseEvent(new DeletedCustomerEvent(request.Id));
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            if (!request.IsInValidState())
            {
                NotifyValidationErrors(request);
                return await Task.FromResult(false);
            }
            var customer = new Customer(Guid.NewGuid(), request.CompanyName, request.ContactName,
                              request.ContactTitle, request.Address, request.City, request.Region,
                              request.PostalCode, request.Country, request.Phone, request.Fax, request.EmailAddress);
            var existingCustomer = _customerRepository.GetCustomerByEmailAddress(customer.EmailAddress);
            if(existingCustomer!=null && existingCustomer.Id != customer.Id)
            {
                if (!existingCustomer.Equals(customer))
                {
                    await _bus.RaiseEvent(new CRMCoreNotification(request.MessageType, "This email is already registered.."));
                    return await Task.FromResult(false);
                }
            }
            _customerRepository.UpdateCustomer(customer);
            if(await Commit())
            {
                await _bus.RaiseEvent(new UpdatedCustomerEvent(request.Id, request.CompanyName, request.ContactName,
                               request.ContactTitle, request.Address, request.City, request.Region,
                               request.PostalCode, request.Country, request.Phone, request.Fax, request.EmailAddress));
            }
            return await Task.FromResult(true);
        }
    }
}
