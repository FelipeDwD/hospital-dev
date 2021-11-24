using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;

namespace Hospital.WebApi.Service.Services
{
    public class UserService : BaseService<UserModel>, IUserService
    {
        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {

        }
    }
}
