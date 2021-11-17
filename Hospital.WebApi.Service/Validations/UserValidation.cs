using FluentValidation;
using Hospital.WebApi.Domain.Entities;
using System;

namespace Hospital.WebApi.Service.Validations
{
    public class UserValidation : AbstractValidator<UserModel>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage(BaseValidation.RequiredField("Nome"))
                .Length(min: 3, max: 20).WithMessage("O campo Nome deve ter entre 3 a 20 caracteres");

            RuleFor(x => x.Surname)
                .NotEmpty().WithMessage(BaseValidation.RequiredField("Sobrenome"))
                .Length(min: 2, max: 20).WithMessage("O campo Nome deve ter entre 2 a 20 caracteres");

            RuleFor(x => x.BirthDate)
                .NotEmpty().WithMessage(BaseValidation.RequiredField("Data de Nascimento"))
                .Must(IsValidYear).WithMessage("O ano de nascimetno deve ser menor que o ano atual")
                .Must(IsValidAge).WithMessage("O colaborador deve ter no mínimo 15 anos");            
        }

        private static bool IsValidYear(DateTime currentYear) =>
            currentYear.Year < DateTime.Now.Year;

        private static bool IsValidAge(DateTime birthDate) =>
            birthDate <= DateTime.Now.AddYears(-15);        
    }
}
