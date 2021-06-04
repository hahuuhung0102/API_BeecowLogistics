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

        [HttpGet("{username}")]
        public async Task<IActionResult> GetLogin(string username)
        {
            var result = await _loginService.GetLoginAsync(username);

            if (result is null)
            {
                return CreateNotFoundResponse(StringContanst.NOT_FOUND);
            }

            return CreateSuccessResponse(result);
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
        
    }
}
