using Hospital.WebApi.Domain.Interfaces.Services;
using Hospital.WebApi.Domain.Models;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace Hospital.WebApi.Service.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;
        private readonly ITokenDescriptorService _tokenDescriptorService;
        public TokenService(IConfiguration configuration, 
                            ITokenDescriptorService tokenDescriptorService)
        {
            _configuration = configuration;
            _tokenDescriptorService = tokenDescriptorService;
        }            
        
        public string GenerateToken(UserModel userModel)
        {
            var key = _configuration.GetValue<string>("Jwt:Secret");
            var securityKey = Encoding.ASCII.GetBytes(key);
            var tokenDescriptor = _tokenDescriptorService.Get(userModel, securityKey);
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
