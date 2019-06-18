using CRM.Core.Domain.Messages;
using FluentValidation.Results;
using System;

namespace CRM.Core.Domain.Commands
{
    public abstract class Command : Message
    {
        public DateTimeOffset TimeStamp { get; protected set; }
        public ValidationResult ValidationResults { get; set; }
        public Command()
        {
            TimeStamp = DateTimeOffset.Now;
        }
        public abstract bool IsInValidState();
    }
}
