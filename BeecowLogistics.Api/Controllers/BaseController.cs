using BeecowLogistics.Services.Commons;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeecowLogistics.Api.Controllers
{
    public class BaseController: ControllerBase
    {
        public BaseController()
        {
        }

        protected IActionResult CreateSuccessResponse<T>(T data, string message = null)
        {
            var response = new ResponseModel<T>
            {
                Data = data,
                IsSuccess = true,
                Message = message ?? "Your request has been successfully completed",
                ErrorDetails = null
            };

            return Ok(response);
        }

        protected IActionResult CreateErrorResponse(string errorMessage)
        {
            var response = new ResponseModel<object>
            {
                Data = null,
                IsSuccess = false,
                Message = errorMessage,
                ErrorDetails = null
            };

            return BadRequest(response);
        }

        protected IActionResult CreateNotFoundResponse(string message)
        {
            var response = new ResponseModel<object>
            {
                Data = null,
                IsSuccess = false,
                Message = message,
                ErrorDetails = null
            };

            return NotFound(response);
        }

        protected IActionResult CreateErrorResponse()
        {
            var response = new ResponseModel<object>
            {
                Data = null,
                IsSuccess = false,
                Message = "Your request failed to complete",
                ErrorDetails = new Dictionary<string, string> { { "error", "Internal server error" } }
            };

            return BadRequest(response);

        }

    }
}
