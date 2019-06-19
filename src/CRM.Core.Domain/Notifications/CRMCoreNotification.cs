using CRM.Core.Domain.Events;
using System;

namespace CRM.Core.Domain.Notifications
{
    public class CRMCoreNotification : Event
    {
        public Guid NotificationId { get; protected set; }
        public int Version { get; protected set; }
        public string Key { get; protected set; }
        public string Value { get; protected set; }
        public CRMCoreNotification(string key, string value)
        {
            NotificationId = Guid.NewGuid();
            Version = 1;
            Key = key;
            Value = value;
        }
    }
}
