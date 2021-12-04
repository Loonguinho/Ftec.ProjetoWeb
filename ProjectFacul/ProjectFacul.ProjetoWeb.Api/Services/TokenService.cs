using Microsoft.IdentityModel.Tokens;
using ProjectFacul.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFacul.ProjetoWeb.Api.Services
{
    public class TokenServices
    {
        public static string GenerateToken(Usuarios user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            //Chave de conhecimento apenas do servidor para gerar o token
            var key = Encoding.ASCII.GetBytes("fedaf7d8863b48e197b9287d492b708e");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Usuario.ToString()),
                    new Claim(ClaimTypes.Role, user.Senha.ToString())
                }),
                //Tempo de validade do token
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
