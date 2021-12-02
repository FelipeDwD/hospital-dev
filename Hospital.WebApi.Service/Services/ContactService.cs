using Hospital.WebApi.Domain.Interfaces.Repository;
using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;
using System.Threading.Tasks;

namespace Hospital.WebApi.Service.Services
{
    public class ContactService : BaseService<ContactModel>, IContactService
    {
        private readonly IContactRepository _contactRepository;
        public ContactService(IContactRepository contactRepository)
            : base(contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task<ContactModel> GetByEmailAsync(string email) =>
            await _contactRepository.GetByEmailAsync(email);        
    }
}
