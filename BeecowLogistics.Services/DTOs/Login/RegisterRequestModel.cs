using BeecowLogistics.Services.DTOs.Users;
using System;

namespace BeecowLogistics.Services.DTOs.Login
{
    public class RegisterRequestModel
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
