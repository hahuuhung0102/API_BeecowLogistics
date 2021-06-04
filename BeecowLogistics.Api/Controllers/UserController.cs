using BeecowLogistics.Services.DTOs.Users;
using BeecowLogistics.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeecowLogistics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController( IUserService userService )
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginUserModel loginRequest)
        {
            if (loginRequest == null || string.IsNullOrEmpty(loginRequest.Username))
            {
                return BadRequest("Missing login details");
            }

            var loginResponse = await _userService.Login(loginRequest);

            if (loginResponse == null)
            {
                return Ok(new { status = 104, message = $"The username or password was not correct" });
            }

            return Ok(loginResponse);
        }
    }
}
