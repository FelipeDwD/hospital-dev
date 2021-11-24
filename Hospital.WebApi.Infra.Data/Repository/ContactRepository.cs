using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Models;
using Hospital.WebApi.Infra.Data.Context;

namespace Hospital.WebApi.Infra.Data.Repository
{
    public class ContactRepository : Repository<ContactModel>, IContactRepository
    {
        public ContactRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {

        }
    }
}
