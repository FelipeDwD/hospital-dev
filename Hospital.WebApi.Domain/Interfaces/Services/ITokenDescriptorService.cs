using Hospital.WebApi.Domain.Models;
using Microsoft.IdentityModel.Tokens;

namespace Hospital.WebApi.Domain.Interfaces.Services
{
    public interface ITokenDescriptorService
    {
        SecurityTokenDescriptor Get(UserModel userModel, byte[] securityKey);
    }
}
