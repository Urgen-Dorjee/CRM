using CRM.Core.Domain.Messages;
using MediatR;
using System;

namespace CRM.Core.Domain.Events
{
    public abstract class Event : Message, INotification
    {
        public DateTimeOffset TimeStamp { get; set; }
        public Event()
        {
            TimeStamp = DateTimeOffset.Now;
        }
    }
}
