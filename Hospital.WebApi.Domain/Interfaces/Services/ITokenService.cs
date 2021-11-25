using Hospital.WebApi.Domain.Models;

namespace Hospital.WebApi.Domain.Interfaces.Services
{
    public interface ITokenService
    {
        string GenerateToken(UserModel userModel);
    }
}
