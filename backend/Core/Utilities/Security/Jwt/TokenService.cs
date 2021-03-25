using Entities.Entity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Core.Utilities.Security.Jwt
{
    public class TokenService : ITokenService
    {
        public string CreateToken(User user)
        {
            var someClaims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.UniqueName,user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.AuthTime,DateTime.Now.AddHours(1).ToString()),
            };
            SecurityKey securityKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("PurpleBackendApiVersion1"));
            var token = new JwtSecurityToken(
                claims: someClaims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
