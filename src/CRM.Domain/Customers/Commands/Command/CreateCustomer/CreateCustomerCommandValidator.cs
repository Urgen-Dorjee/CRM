using CRM.Domain.Customers.Commands.Validations;

namespace CRM.Domain.Customers.Commands.Command.CreateCustomer
{
    public class CreateCustomerCommandValidator : CustomerValidationHandler<CreateCustomerCommand>
    {
        public CreateCustomerCommandValidator()
        {
            ValidateCustomerProperties();
        }
    }
}
