using Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Call_in_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        [Route("register")]
        public IActionResult Register([FromBody] Register register)
        {
            var obj = new Register
            {
                Username = register.Username,
                Email = register.Email,
                Password = register.Password
            };
            return Ok(obj);
        }
    }
}
