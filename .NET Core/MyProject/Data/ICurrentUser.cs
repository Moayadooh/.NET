using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface ICurrentUser
    {
        public bool AuthenticateUser([FromBody] Login login);

        public string GenerateJSONWebToken();
    }
}
