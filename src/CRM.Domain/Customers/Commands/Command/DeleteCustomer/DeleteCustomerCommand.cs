using System;

namespace CRM.Domain.Customers.Commands.Command.DeleteCustomer
{
    public class DeleteCustomerCommand : CustomerCommand
    {
        public DeleteCustomerCommand(Guid id) : base(id)
        { }

        public override bool IsInValidState()
        {
            ValidationResults = new DeleteCustomerCommandValidator().Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
