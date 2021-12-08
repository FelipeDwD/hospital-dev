using Hospital.WebApi.Domain.Models;
using System.Threading.Tasks;

namespace Hospital.WebApi.Domain.Interfaces.Repository
{
    public interface IContactRepository : IRepository<ContactModel>
    {
        Task<ContactModel> GetByEmailAsync(string email);
        Task<ContactModel> GetByCellPhoneAsync(string cellPhone);
    }
}
