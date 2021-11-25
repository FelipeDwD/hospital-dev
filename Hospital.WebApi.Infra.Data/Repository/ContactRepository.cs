using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hospital.WebApi.Infra.Data.Repository
{
    public class ContactRepository : Repository<ContactModel>, IContactRepository
    {
        public ContactRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {

        }

        public async Task<ContactModel> GetByEmailAsync(string email) =>
            await _dbSet.FirstOrDefaultAsync(x => x.Email == email);       
    }
}
