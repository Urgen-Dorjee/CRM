using CRM.Core.Domain.Bus;
using CRM.Core.Domain.Commands;
using CRM.Core.Domain.Notifications;
using CRM.Domain.Interfaces;
using MediatR;
using System.Threading.Tasks;

namespace CRM.Domain.Customers.Commands.ComandHandlers
{
    public class CommandHandler
    {
        private readonly IMediatorHandler _bus;
        private readonly CRMCoreNotificationHandler _notification;
        private readonly IUnitOfWork _unit;

        public CommandHandler(IMediatorHandler bus, INotificationHandler<CRMCoreNotification> notification,
                             IUnitOfWork unit)
        {
            _bus = bus;
            _notification = (CRMCoreNotificationHandler)notification;
            _unit = unit;
        }

        protected void NotifyValidationErrors(CoreCommand message)
        {
            foreach(var error in message.ValidationResults.Errors)
            {
                _bus.RaiseEvent(new CRMCoreNotification(message.MessageType, error.ErrorMessage));
            }
        }

        public async Task<bool> Commit()
        {
            if (_notification.HasAnyNotification()) return false;
            if (_unit.Commit())
            {
                return true;
            }
            await _bus.RaiseEvent(new CRMCoreNotification("Commit", "Error while saving data.."));
            return await Task.FromResult(false);
        }
    }
}
