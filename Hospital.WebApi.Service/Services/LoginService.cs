using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;

namespace Hospital.WebApi.Service.Services
{
    public class LoginService : BaseService<LoginModel>, ILoginService
    {
        public LoginService(ILoginRepository loginRepository)
            : base(loginRepository)
        {

        }
    }
}
