using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CRM.Core.Domain.Notifications
{
    public class CRMCoreNotificationHandler : INotificationHandler<CRMCoreNotification>
    {
        private List<CRMCoreNotification> _notification;
        public CRMCoreNotificationHandler()
        {
            _notification = new List<CRMCoreNotification>();
        }
        public Task Handle(CRMCoreNotification message, CancellationToken cancellationToken)
        {
            _notification.Add(message);
            return Task.CompletedTask;
        }
        public List<CRMCoreNotification> GetAllNotifications()
        {
            return _notification;
        }
        public virtual bool HasAnyNotification()
        {
            return GetAllNotifications().Any();
        }
        public void Dispose()
        {
            _notification = new List<CRMCoreNotification>();
        }
    }
}
