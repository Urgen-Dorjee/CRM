using MediatR;
using System;

namespace CRM.Core.Domain.Messages
{
    public abstract class Message : IRequest<bool>
    {
        public string MessageType { get; protected set; }
        public Guid MessagesAggregate { get; protected set; }
        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
