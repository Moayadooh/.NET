using Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly ICurrentUser _currentUser;

        public UserController(ICurrentUser currentUser)
        {
            _currentUser = currentUser;
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] Login login)
        {
            IActionResult response = Unauthorized();
            var isValid = _currentUser.AuthenticateUser(login);

            if (isValid)
            {
                var tokenString = _currentUser.GenerateJSONWebToken();
                response = Ok(new { token = tokenString });
            }

            return response;
        }
    }
}
