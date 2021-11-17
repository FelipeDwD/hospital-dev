using Hospital.WebApi.Domain.Interfaces.Services.Validations;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Service.Validations;

namespace Hospital.WebApi.Service.Services.Validations
{
    public class ContactValidationService : ValidationBaseService<ContactModel>, IContactValidationService
    {
        public ContactValidationService(ContactValidation contactValidation)
        : base(contactValidation)
        {

        }
    }
}
