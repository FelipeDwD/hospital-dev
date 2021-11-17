using FluentValidation;
using FluentValidation.Results;
using Hospital.WebApi.Domain.Interfaces.Services.Validations;
using Hospital.WebApi.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.WebApi.Service.Services.Validations
{
    public abstract class ValidationBaseService<T> : IValidationBaseService<T> where T : BaseEntityModel
    {
        private AbstractValidator<T> _typeValidation;

        public ValidationBaseService(AbstractValidator<T> typeValidation) =>
            _typeValidation = typeValidation;        

        public List<string> Validate(T entity)
        {
            var validator = _typeValidation.Validate(entity);

            if (validator.IsValid)
                return null;

            var messages = GetMessages(validator);
            return messages;
        }

        private List<string> GetMessages(ValidationResult validationResult)
        {
            var errors = (from error in validationResult.Errors
                          select error.ErrorMessage).ToList();

            return errors;
        }
    }
}
