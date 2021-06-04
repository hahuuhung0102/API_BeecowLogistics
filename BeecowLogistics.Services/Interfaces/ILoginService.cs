using BeecowLogistics.Services.DTOs.Login;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Interfaces
{
    public interface ILoginService
    {
        public Task<LoginModel> GetLoginAsync(string username);

        public Task<string> AuthencateAsync(LoginRequestModel request);

        //public Task<IdentityResult> AddLoginAsync(RegisterRequestModel request);
    }
}
