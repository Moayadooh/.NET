using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Data
{
    public class CurrentUser : ICurrentUser
    {
        private readonly ApplicationDbContext _db;

        public CurrentUser(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool AuthenticateUser([FromBody] Login login)
        {
            var obj = _db.Logins.Where(x => x.Email == login.Email && x.Password == login.Password);
            if (obj.Count() > 0)
                return true;
            return false;
        }

        public string GenerateJSONWebToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MyKeysdvsvsdvzdvzdfberabadvsva"));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                "moayad.com",
                "moayad.com",
                null,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: credentials);

            //var tokenHandler = new JwtSecurityTokenHandler();
            //var tokenDescriptor = new SecurityTokenDescriptor
            //{
            //    Subject = new ClaimsIdentity(new Claim[]
            //    {
            //        new Claim("software", "")
            //    }),
            //    Expires = DateTime.UtcNow.AddHours(3),
            //    SigningCredentials = credentials
            //};
            //var token = tokenHandler.CreateToken(tokenDescriptor);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
