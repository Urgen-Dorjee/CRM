using CRM.Domain.Customers.Commands.Validations;

namespace CRM.Domain.Customers.Commands.Command.UpdateCustomer
{
    public class UpdatedCustomerCommandValidator : CustomerValidationHandler<UpdateCustomerCommand>
    {
        public UpdatedCustomerCommandValidator()
        {
            ValidateCustomerProperties();
        }
    }
}
