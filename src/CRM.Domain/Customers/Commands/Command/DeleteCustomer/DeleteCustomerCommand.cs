namespace CRM.Domain.Customers.Commands.Command.DeleteCustomer
{
    public class DeleteCustomerCommand : CustomerCommand
    {
        public DeleteCustomerCommand(string id) : base(id)
        { }

        public override bool IsInValidState()
        {
            ValidationResults = new DeleteCustomerCommandValidator().Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
