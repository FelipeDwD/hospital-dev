using FluentValidation;
using Hospital.WebApi.Domain.Entities;
using System.Text.RegularExpressions;

namespace Hospital.WebApi.Service.Validations
{
    public class ContactValidation : AbstractValidator<ContactModel>
    {
        public ContactValidation()
        {
            RuleFor(x => x.CellPhone)
                .NotEmpty().WithMessage(BaseValidation.RequiredField("celular"))
                .Must(IsCellPhoneValid).WithMessage(BaseValidation.FieldInvalidFormat("celular"));

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(BaseValidation.RequiredField("E-mail"))
                .EmailAddress().WithMessage(BaseValidation.FieldInvalidFormat("E-mail"));
        }

        private static bool IsCellPhoneValid(string cellPhone)
        {
            string pattern = @"[(][0-9]{2}[)][9][0-9]{4}[-][0-9]{4}";
            Regex regex = new Regex(pattern);
            return regex.Match(cellPhone).Success;
        }
    }
}
