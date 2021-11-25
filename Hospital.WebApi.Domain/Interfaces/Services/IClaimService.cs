using Hospital.WebApi.Domain.Models;
using System.Collections.Generic;
using System.Security.Claims;

namespace Hospital.WebApi.Domain.Interfaces.Services
{
    public interface IClaimService
    {
        IEnumerable<Claim> GetList(UserModel userModel);
    }
}
