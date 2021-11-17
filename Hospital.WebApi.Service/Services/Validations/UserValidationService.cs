using Hospital.WebApi.Domain.Interfaces.Services.Validations;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Service.Validations;

namespace Hospital.WebApi.Service.Services.Validations
{
    public class UserValidationService : ValidationBaseService<UserModel>, IUserValidationService
    {
        public UserValidationService(UserValidation userValidation)
        : base(userValidation)
        {

        }
    }
}
