using CRM.Domain.Customers.Commands.Command;
using FluentValidation;
using System;

namespace CRM.Domain.Customers.Commands.Validations
{
    public class CustomerValidationHandler<T> : AbstractValidator<T> where T : CustomerCommand
    {
        protected void ValidateCustomerProperties()
        {
            RuleFor(x => x.Address).MaximumLength(60);
            RuleFor(x => x.City).MaximumLength(15);
            RuleFor(x => x.CompanyName).MaximumLength(40).NotEmpty();
            RuleFor(x => x.ContactName).MaximumLength(30);
            RuleFor(x => x.ContactTitle).MaximumLength(30);
            RuleFor(x => x.Country).MaximumLength(15);
            RuleFor(x => x.Fax).MaximumLength(24);
            RuleFor(x => x.Phone).MaximumLength(24);
            RuleFor(x => x.PostalCode).MaximumLength(10).NotEmpty();
            RuleFor(x => x.Region).MaximumLength(15);
        }

        protected void ValidateCustomerIdField()
        {
            RuleFor(c => c.Id).NotEqual(Guid.Empty).WithMessage("Customer Id is empty, enter customer Id to update the record");
        }
    }
}
