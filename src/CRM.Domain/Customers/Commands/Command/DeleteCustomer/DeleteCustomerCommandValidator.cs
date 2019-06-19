using CRM.Domain.Customers.Commands.Validations;

namespace CRM.Domain.Customers.Commands.Command.DeleteCustomer
{
    public class DeleteCustomerCommandValidator : CustomerValidationHandler<DeleteCustomerCommand>
    {
        public DeleteCustomerCommandValidator()
        {
            ValidateCustomerIdField();
        }
    }
}
