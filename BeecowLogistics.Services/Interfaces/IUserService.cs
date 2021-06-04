using BeecowLogistics.Services.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeecowLogistics.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserResponse> Login (LoginUserModel loginRequest);
    }
}
