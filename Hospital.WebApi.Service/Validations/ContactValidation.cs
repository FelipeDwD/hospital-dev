using FluentValidation;
using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;
using System.Text.RegularExpressions;

namespace Hospital.WebApi.Service.Validations
{
    public class ContactValidation : AbstractValidator<ContactModel>
    {
        private readonly IDddService _dddService;        
        
        public ContactValidation(IDddService dddService)
        {
            _dddService = dddService;

            RuleFor(x => x.CellPhone)
                .NotEmpty().WithMessage(BaseValidation.RequiredField("celular"))
                .Must(IsCellPhoneValid).WithMessage(BaseValidation.FieldInvalidFormat("celular"))
                .Must(_dddService.IsValid).WithMessage("Campo celular possui um ddd inválido");

            RuleFor(x => x.Email)
                .NotEmpty().WithMessage(BaseValidation.RequiredField("E-mail"))
                .EmailAddress().WithMessage(BaseValidation.FieldInvalidFormat("E-mail"));
        }

        public bool IsCellPhoneValid(string cellPhone)
        {
            string pattern = @"^[(][1-9]{2}[)][9][0-9]{4}[-][0-9]{4}$";
            Regex regex = new Regex(pattern);
            var match = regex.IsMatch(cellPhone);
            return match;
        }
    }
}
