using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Claims;

namespace Hospital.WebApi.Service.Services
{
    public class TokenDescriptorService : ITokenDescriptorService
    {
        private readonly IClaimService _claimService;
        public TokenDescriptorService(IClaimService claimService) =>
            _claimService = claimService;
        

        public SecurityTokenDescriptor Get(UserModel userModel, byte[] securityKey)
        {
            var claims = _claimService.GetList(userModel);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials
                (
                 new SymmetricSecurityKey(securityKey),
                 SecurityAlgorithms.HmacSha256
                )
            };
            return tokenDescriptor;
        }                     
    }
}
