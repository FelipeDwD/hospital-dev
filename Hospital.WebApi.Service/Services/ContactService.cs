using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;

namespace Hospital.WebApi.Service.Services
{
    public class ContactService : BaseService<ContactModel>, IContactService
    {
        public ContactService(IContactRepository contactRepository)
            : base(contactRepository)
        {

        }        
    }
}
