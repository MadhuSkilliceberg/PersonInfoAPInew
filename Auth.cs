using Microsoft.IdentityModel.Tokens;
using PersonsInfoV2Api.CoustumModels;
using PersonsInfoV2Api.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PersonsInfoV2Api
{

    public class Auth : IJwtAuth
    {
        private readonly string key;
        public Auth(string key)
        {
            this.key = key;
        }
        public AuthenticatedResponse Authentication(string username, string password)
        {

            PersonsInfoV3NewContext context = new PersonsInfoV3NewContext();
           // var dataList = context.Users.ToList();
            var data = context.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();

            if (data == null)
                return null;
            // Logic write hear
            //if (!(username.Equals(username) && password.Equals(password)))
            //{
            //    return null;
            //}


            // 1. Create Security Token Handler
            var tokenHandler = new JwtSecurityTokenHandler();

            // 2. Create Private Key to Encrypted
            var tokenKey = Encoding.ASCII.GetBytes(key);

            //3. Create JETdescriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, username)
                    }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            //4. Create Token
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // 5. Return Token from method
            var tokenString= tokenHandler.WriteToken(token);
            return new AuthenticatedResponse { Token = tokenString };
        }
    }

}
