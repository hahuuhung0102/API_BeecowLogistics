using BeecowLogistics.Services.Commons;
using BeecowLogistics.Services.DTOs.Login;
using BeecowLogistics.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BeecowLogistics.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : BaseController
    {
        private ILoginService _loginService;

        public LoginController(ILoginService loginBussinessService)
        {
            _loginService = loginBussinessService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequestModel request)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var resultToken = await _loginService.AuthencateAsync(request);
            if (string.IsNullOrEmpty(resultToken))
            {

                return CreateErrorResponse("Username or Password incorrect");
            }

            return Ok(new { token = resultToken });
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] RegisterRequestModel request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _loginService.AddLoginAsync(request);
            if (!result)
            {
                return CreateErrorResponse();
            }
            return CreateSuccessResponse("Register is successful");
        }

    }
}
