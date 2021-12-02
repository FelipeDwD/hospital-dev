using Hospital.WebApi.Domain.Models;
using System.Threading.Tasks;

namespace Hospital.WebApi.Domain.Interfaces.Services
{
    public interface IContactService : IBaseService<ContactModel>
    {
        Task<ContactModel> GetByEmailAsync(string email);
    }
}
