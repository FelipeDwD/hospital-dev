using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hospital.WebApi.Infra.Data.Repository
{
    public class LoginRepository : Repository<LoginModel>, ILoginRepository
    {
        public LoginRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {

        }      
    }
}
