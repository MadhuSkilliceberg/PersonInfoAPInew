using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging.Abstractions;
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
        private readonly PersonsInfoV3NewContext context;
        private readonly string key;
        public Auth(PersonsInfoV3NewContext context, string key)
        {
            this.context = context;
            this.key = key;
        }
        public AuthenticatedResponse Authentication(UserCredential userCredential)
        {
            var data = context.Users.FirstOrDefault(u => u.Username == userCredential.UserName && u.Password == userCredential.Password);

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

            DateTime expires = DateTime.UtcNow.AddHours(1);

            //3. Create JETdescriptor
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, userCredential.UserName)
                    }),
                Expires = expires,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            //4. Create Token
            var token = tokenHandler.CreateToken(tokenDescriptor);

            // 5. Return Token from method
            var tokenString= tokenHandler.WriteToken(token);
            UserTokenSession userTokenSession = new UserTokenSession()
            {
                IsActive = true,
                AccessToken = tokenString,
                CreatedOn = DateTime.UtcNow,
                LoginTime = DateTime.UtcNow,
                UserId = data.Id,
                TokenExpires = expires,
                BrowserInfo = userCredential.userDevice.browser + " " + userCredential.userDevice.browser_version,
                OperatingSystem = userCredential.userDevice.os + " "+ userCredential.userDevice.os_version,
                DeviceType = userCredential.userDevice.deviceType,
                IpAddress = null 
            };

            context.UserTokenSessions.Add(userTokenSession);
            context.SaveChanges();
            return new AuthenticatedResponse { Token = tokenString, Username = userCredential.UserName, UserId= data.Id };
        }
    }

}
