using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;
using System.Collections.Generic;
using System.Security.Claims;
using System.Linq;

namespace Hospital.WebApi.Service.Services
{
    public class ClaimService : IClaimService
    {
        public IEnumerable<Claim> GetList(UserModel userModel)
        {
            var claims = new List<Claim>();
            claims.Add(GetClaimTypeName(userModel));
            claims.AddRange(GetClaimsTypeRole(userModel));
            return claims;
        }

        private IEnumerable<Claim> GetClaimsTypeRole(UserModel userModel) =>
              (from userRole in userModel.UserRoles
               select new Claim(ClaimTypes.Role, userRole.Role.Name));

        private Claim GetClaimTypeName(UserModel userModel) =>
            new Claim(ClaimTypes.Name, userModel.Name);
    }
}
