using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Infra.Data.Context;

namespace Hospital.WebApi.Infra.Data.Repository
{
    public class UserRepository : Repository<UserModel>, IUserRepository
    {
        public UserRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {

        }
    }
}
