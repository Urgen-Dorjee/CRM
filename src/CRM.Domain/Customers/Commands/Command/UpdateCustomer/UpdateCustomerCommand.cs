using System;

namespace CRM.Domain.Customers.Commands.Command.UpdateCustomer
{
    public class UpdateCustomerCommand : CustomerCommand
    {
        public UpdateCustomerCommand(Guid customerId, string company, string contact, string contactTitle, string address,
                        string city, string region, string post, string country, string phone, string fax, string email)
         : base(customerId, company, contact, contactTitle, address, city, region, post, country, phone, fax, email)
        { }
        public override bool IsInValidState()
        {
            ValidationResults = new UpdatedCustomerCommandValidator().Validate(this);
            return ValidationResults.IsValid;
        }
    }
}
