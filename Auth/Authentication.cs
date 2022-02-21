using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace YFE_API.Auth
{
    public class Authentication
    {
        public string Authenticate(string email)
        {
            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Email,email)
            };

            var secretBytes = Encoding.UTF8.GetBytes(Constants.Secret);
            var key = new SymmetricSecurityKey(secretBytes);
            var algorithm = SecurityAlgorithms.HmacSha256;

            var signingCredentials = new SigningCredentials(key, algorithm);

            var token = new JwtSecurityToken(
                Constants.Issuer,
                Constants.Audiance,
                claims,
                notBefore: DateTime.Now,
                expires: DateTime.Now.AddHours(1),
                signingCredentials
                );

            var tokenJson = new JwtSecurityTokenHandler().WriteToken(token);

            return tokenJson;
        }


        public void TokenCheck(JwtBearerOptions config) {
            var secretBytes = Encoding.UTF8.GetBytes(Constants.Secret);
            var key = new SymmetricSecurityKey(secretBytes);

            config.Events = new JwtBearerEvents()
            {
                OnMessageReceived = context =>
                {
                    if (context.Request.Query.ContainsKey("access_token")) 
                    {
                        context.Token = context.Request.Query["access_token"];
                    }

                    return Task.CompletedTask;
                }
            };

            config.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidIssuer = Constants.Issuer,
                ValidAudience = Constants.Audiance,
                IssuerSigningKey=key
            };
        }
    }
}
