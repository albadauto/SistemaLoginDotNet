using Microsoft.IdentityModel.Tokens;
using SysLogin.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SysLogin.Services
{
    public static class TokenService
    {
        public static string GenerateToken(UserModel user)
        {
            var tokenHandler = new JwtSecurityTokenHandler(); // Instancia o objeto para criar o token
            var key = Encoding.ASCII.GetBytes(Settings.Secret); // Encripta o secret
            var tokenDescriptor = new SecurityTokenDescriptor // Configura o token
            {
                Expires = DateTime.UtcNow.AddHours(8), //Quando inspira
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature), //Como vai descriptografar
                Subject = new System.Security.Claims.ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Role, user.Role),

                })
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
