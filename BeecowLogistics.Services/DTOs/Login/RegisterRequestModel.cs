using BeecowLogistics.Services.DTOs.Users;
using System;

namespace BeecowLogistics.Services.DTOs.Login
{
    public class RegisterRequestModel : UserModel
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
