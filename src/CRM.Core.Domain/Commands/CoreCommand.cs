using CRM.Core.Domain.Messages;
using FluentValidation.Results;
using System;

namespace CRM.Core.Domain.Commands
{
    public abstract class CoreCommand : Message
    {
        public DateTimeOffset TimeStamp { get; protected set; }
        public ValidationResult ValidationResults { get; set; }
        public CoreCommand()
        {
            TimeStamp = DateTimeOffset.Now;
        }
        public abstract bool IsInValidState();
    }
}
